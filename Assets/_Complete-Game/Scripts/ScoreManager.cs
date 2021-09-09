using UnityEngine;

public abstract class ScoreManager : MonoBehaviour
{
    private string deviceId = SystemInfo.deviceUniqueIdentifier;
    private int highscore;

    private void GetHighScore()
    {
        highscore = PlayerPrefs.GetInt("Highscore");
    }

    public abstract void ShareHighScore();
}
