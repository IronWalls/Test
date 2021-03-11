using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create/NewLevelData", fileName = "NewLevelData")]
public class LevelData : ScriptableObject
{
    [Tooltip("Time to wait before starting level, in seconds.")]
    public float levelStartDelay = 2f; 
    [Tooltip("Delay between each Player turn.")]
    public float turnDelay = 0.1f;
    [Tooltip("Starting value for Player food points.")]
    public int playerFoodPoints = 100;
}
