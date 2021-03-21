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

    //For the enemy count
    public int[] enemisAmount;

    //Two sub tasks below done in 2 ways, 1 through dirrectly addresing columns and rows, second via vector
    //Exit cordinates
    public int exitColomn;
    public int exitRow;
    //Player start cordinates
    public Vector2Int playerStartPosition;

    //Food cap
    public int foodCapAmount;
    //Food cap message
    public string foodCapMessage;
}
