using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleSpawnEnemyLog : IRuleSpawnEnemy
{
    public float coefficient { get; set; } = 1;
    public int RuleSpawn(int level) => (int)(Mathf.Log(level, 2f) * coefficient);

    public RuleSpawnEnemyLog(float coef = 1)
    {
        if (coef <= 0) coef = 1;
        this.coefficient = coef;
    }
}
