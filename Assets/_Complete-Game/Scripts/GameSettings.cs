using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "GameMode/Configuration")]

public class GameSettings : ScriptableObject
{
    public int enemyMultiplier; //The base of the logarithm which calculatese the number of enemies.
    public int exitPositionX; //Substracted X position from the right top corner.
    public int exitPositionY; //Substracted Y position from the right top corner.
    public int columns; //Number of columns in our game board.
    public int rows; //Number of rows in our game board.

}

