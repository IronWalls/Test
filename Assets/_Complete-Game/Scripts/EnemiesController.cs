using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Completed
{

    [CreateAssetMenu(menuName = "Enemies Controller")]
    public class EnemiesContoroller : ScriptableObject
    {
        public List<Enemy> enemies;
    }
}

