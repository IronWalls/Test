using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Score : MonoBehaviour
{
    [Serializable]
    public struct Record
    {
        public string Name;
        public int score;
        public Record(string name, int score)
        {
            this.Name = name;
            this.score = score;
        }
    }

    public List<Record> localRecords = new List<Record>();

    public abstract void SaveScore();
    public abstract void GetScores();
    public abstract void AddScores(Record newScore);
}
