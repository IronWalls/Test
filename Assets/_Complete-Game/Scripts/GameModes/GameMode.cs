using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public enum EnemyCountMode 
{
    LevelBased,
    Fixed,
    Random
}

[CreateAssetMenu(fileName = "GameMode_1", menuName = "GameModes/Create New", order = 1)]
public class GameMode : ScriptableObject
{
    [Header("General Settings")]
    public float levelStartDelay = 2f; //Time to wait before starting level, in seconds.
    public float turnDelay = 0.1f; //Delay between each Player turn.
    public int playerFoodPoints = 100; //Starting value for Player food points.

    [Header("Enemy Settings")]
    public EnemyCountMode enemyCountMode;

    [Min(0)]
    public int enemyCountMin = 0;
    [Min(1)]
    public int enemyCountMax = 4;
    [Min(0)]
    public int enemyCountFixed = 2;
    [Min(2f)]
    public float enemyLevelMultiplicator = 2f;

    public int GetEnemyCount(int level = 0) 
    {
        switch (enemyCountMode)
        {
            case EnemyCountMode.LevelBased:
                return GetLevelBasedEnemyCount(level);
            case EnemyCountMode.Fixed:
                return GetFixedEnemyCount();
            case EnemyCountMode.Random:
                return GetRandomEnemyCount();
            default:
                return GetLevelBasedEnemyCount(level);
        }
    }
    private int GetLevelBasedEnemyCount(int level) 
    {
        return (int)Mathf.Log(level, enemyLevelMultiplicator);
    }
    private int GetFixedEnemyCount()
    {
        return enemyCountFixed;
    }
    private int GetRandomEnemyCount()
    {
        return Random.Range(enemyCountMin, enemyCountMax + 1);
    }

    public static GameMode GetDefaultGameMode() 
    {
        return ScriptableObject.CreateInstance<GameMode>();
    }
}