using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreComponent : MonoBehaviour
{
    public Text playerName;
    public Text score;

    public void Init(string name, string highScore) 
    {
        playerName.text = name;
        score.text = highScore;
    }
}