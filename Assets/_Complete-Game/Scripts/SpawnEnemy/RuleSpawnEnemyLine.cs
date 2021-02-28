using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleSpawnEnemyLine : IRuleSpawnEnemy
{
    public float coefficient { get; set; }
    public int RuleSpawn(int level) => (int)(level * coefficient);

    public RuleSpawnEnemyLine(float coef = 1)
    {
        this.coefficient = coef;
    }
}
