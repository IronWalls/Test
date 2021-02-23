using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConfiguratorManager : MonoBehaviour
{
    public List<LevelConfig> LevelConfigs = new List<LevelConfig>();
    [System.Serializable] public struct LevelConfig
    {
        public bool timerIsOn;//Timer mod for level if on player will take damage every second
        public int enemyMinValue;//Minimum value of enemy for the level
        public int enemyMaxValue;//Maximum value of enemy for the level
        public int enemyHitModificator;//Enemy damage modificator for level
        public int exitColumn;// Column settings for level
        public int exitRow;// Row settings for level
    }

   
}
