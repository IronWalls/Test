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

    public List<Vector3> possibleStartPositions = new List<Vector3>();
    public List<Vector3> possibleExitPositions = new List<Vector3>();

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

    private Vector3 deltaStartPosition;
    public Vector3 GetStartPosition() 
    {
        if (possibleStartPositions.Count == 0)
            return Vector3.zero;

        int randomIndex = Random.Range(0, possibleStartPositions.Count);
        return possibleStartPositions[randomIndex];
    }
    public Vector3 GetExitPosition() 
    {
        for (int i = possibleExitPositions.Count - 1; i > 0; i--)
        {
            if (possibleExitPositions[i] == deltaStartPosition) 
            {
                possibleExitPositions.RemoveAt(i);
                break;
            }
        }

        if (possibleExitPositions.Count == 0)
            return new Vector3(0f, 1f, 0f);

        int randomIndex = Random.Range(0, possibleExitPositions.Count - 1);
        return possibleExitPositions[randomIndex];
    }

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