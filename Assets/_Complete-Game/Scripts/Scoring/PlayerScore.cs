using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance = null;

    public GameObject scoreBoard;
    public Transform boardContainer;
    public GameObject scorePrefab;

    private List<Score> scores;

    public PlayerScore()
    {
        instance = this;
    }

    public void OpenScoreBoard(List<Score> scores = null) 
    {
        this.scores = scores;
        if (scores == null)
        {
            this.scores = new List<Score>();
        }
        Score playerScore = new Score() { playerName = "Player", highScore = PlayerPrefs.GetInt("HighScore").ToString() };
        this.scores.Add(playerScore);
        PopulateBoard();
        scoreBoard.SetActive(true);
    }
    public void CloseScoreBoard() 
    {
        scoreBoard.SetActive(false);
        for (int i = boardContainer.transform.childCount - 1; i > 0; i--)
        {
            var child = boardContainer.transform.GetChild(i);
            Destroy(child);
        }
        scores = new List<Score>();
    }

    public void PopulateBoard() 
    {
        foreach (var score in scores)
        {
            InitScore(score);
        }
    }

    public void InitScore(Score score) 
    {
        GameObject instance = Instantiate(scorePrefab);
        instance.transform.SetParent(boardContainer);
        instance.GetComponent<ScoreComponent>().Init(score.playerName, score.highScore);
    }

    public void UpdateScore(int score) 
    {
        if (PlayerPrefs.GetInt("HighScore") < score) 
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}

public class Score 
{
    public string playerName;
    public string highScore;
}