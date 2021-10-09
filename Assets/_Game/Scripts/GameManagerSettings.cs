using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameManagerSettings", menuName = "ScriptableObjects/GameManagerSettings", order = 1)]
public class GameManagerSettings : ScriptableObject
{
   [field:SerializeField] public float LevelStartDelay { get; private set; }= 2f; //Time to wait before starting level, in seconds.
   [field:SerializeField] public float TurnDelay { get; private set; }= 0.1f; //Delay between each Player turn.
   [field:SerializeField] public  int PlayerFoodPoints { get; private set; }= 100; //Starting value for Player food points.
}
