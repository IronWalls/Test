using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRuleSpawnEnemy
{
    float coefficient { get; set; }
    int RuleSpawn(int level);
}
