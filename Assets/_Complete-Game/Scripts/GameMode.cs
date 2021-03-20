using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mode", menuName = "GameMode")]
public class GameMode : ScriptableObject
{
    //For the Game Manager
    public float levelStartDelay;
    public float turnDelay;
    public int playerFoodPoints;

    //For the Board Manager
    public int columns;
    public int rows;
    public int wallCountMinimum;
    public int wallCountMaximum;
    public int foodCountMinimum;
    public int foodCountMaximum;
    public GameObject exit;
    public GameObject[] floorTiles;
    public GameObject[] wallTiles;
    public GameObject[] foodTiles;
    public GameObject[] enemyTiles;
    public GameObject[] outerWallTiles;

}
