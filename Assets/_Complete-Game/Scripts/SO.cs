using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Game Manager")]
public class SO : ScriptableObject
{
    // GameManager
    public float levelStartDelay;//Time to wait before starting level, in seconds.
    public float turnDelay; //Delay between each Player turn.
    public int playerFoodPoints = 100; //Starting value for Player food points.

    // public Count wallCount = new Count(5, 9); //Lower and upper limit for our random number of walls per level.
    // public Count foodCount = new Count(1, 5); //Lower and upper limit for our random number of food items per level.
    // [SerializeField]
    // public class Count
    // {
    //     public int minimum; //Minimum value for our Count class.
    //     public int maximum; //Maximum value for our Count class.


    //     //Assignment constructor.
    //     public Count(int min, int max)
    //     {
    //         minimum = min;
    //         maximum = max;
    //     }

    // }
    public int columns = 8; //Number of columns in our game board.
    public int rows = 8; //Number of rows in our game board.

    public GameObject exit; //Prefab to spawn for exit.
    public GameObject[] floorTiles; //Array of floor prefabs.
    public GameObject[] wallTiles; //Array of wall prefabs.
    public GameObject[] foodTiles; //Array of food prefabs.
    public GameObject[] enemyTiles; //Array of enemy prefabs.
    public GameObject[] outerWallTiles; //Array of outer tile prefabs.
    public GameObject foodMessage;

}