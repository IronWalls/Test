using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RecordsPanel : MonoBehaviour
{
    private string[] TempNames = new string[] { "Peter", "Ron", "Satchmo", "Dio" };
    public GameObject RecordPrefab;
    public Transform Container;
    public Text levelText;
    public Button NewGame;
    public Score scoreManager;

    public void Init(int result, UnityAction newGame)
    {
        //Set levelText to display number of levels passed and game over message
        levelText.text = "After " + result + " days, you starved.";
        scoreManager.GetScores();
        scoreManager.AddScores(new Score.Record(TempNames[UnityEngine.Random.Range(0, TempNames.Length)], result));
        foreach (var record in scoreManager.localRecords)
        {
            var recordItem = Instantiate(RecordPrefab, Container);
            recordItem.GetComponent<Text>().text = $"{record.Name}: {record.score}";
        }
        scoreManager.SaveScore();
        //сохранить
        NewGame.onClick.AddListener(newGame);
    }
}
