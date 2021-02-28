using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Completed.BoardManager;

[CreateAssetMenu(fileName = "LevelParameters", menuName = "ScriptableObjects/SetLevelParameters", order = 1)]
public class LevelParams : ScriptableObject
{
    public int columns = 8; //Number of columns in our game board.
    public int rows = 8; //Number of rows in our game board.
    public Count wallCount = new Count(5, 9); //Lower and upper limit for our random number of walls per level.
    public Count foodCount = new Count(1, 5); //Lower and upper limit for our random number of food items per level.
    public GameObject exit; //Prefab to spawn for exit.
    public GameObject[] floorTiles; //Array of floor prefabs.
    public GameObject[] wallTiles; //Array of wall prefabs.
    public GameObject[] foodTiles; //Array of food prefabs.
    public GameObject[] enemyTiles; //Array of enemy prefabs.
    public GameObject[] outerWallTiles; //Array of outer tile prefabs.
}
