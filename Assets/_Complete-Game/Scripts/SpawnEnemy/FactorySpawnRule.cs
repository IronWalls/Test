using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorySpawnRule
{
    public static IRuleSpawnEnemy GetRuleSpawnEnemy(TypeRuleSpawnEnemy type, float coef)
    {
        IRuleSpawnEnemy rule;
        switch (type)
        {
            case TypeRuleSpawnEnemy.Line:
                rule = new RuleSpawnEnemyLine(coef);
                break;
            case TypeRuleSpawnEnemy.Log:
                rule = new RuleSpawnEnemyLog(coef);
                break;
            default:
                rule = new RuleSpawnEnemyLine();
                break;
        }
        return rule;
    }
}
