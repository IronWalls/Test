using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class ScoreLocalManager : Score
{

    private string dataPath;

    private void Awake()
    {
        dataPath = Path.Combine(Application.dataPath, "records.data");
    }

    public override void SaveScore()
    {
        File.WriteAllText(dataPath, JsonHelper.arrayToJson<Record>(localRecords.ToArray()));
    }

    public override void GetScores()
    {
        if (File.Exists(dataPath))
        {
            localRecords = JsonHelper.getJsonArray<Record>(File.ReadAllText(dataPath)).ToList();
        }
    }

    public override void AddScores(Record newScore)
    {
        localRecords.Add(newScore);
        localRecords = localRecords.OrderByDescending(o => o.score).Take(10).ToList();
    }

    public class JsonHelper
    {
        public static T[] getJsonArray<T>(string json)
        {
            try
            {
                Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
                return wrapper.array;
            }
            catch
            {
                Debug.LogError("Desrealization error");
                return new T[0];
            }
            
        }
        public static string arrayToJson<T>(T[] array)
        {
            Wrapper<T> wrapper = new Wrapper<T>();
            wrapper.array = array;
            return JsonUtility.ToJson(wrapper);
        }

        [Serializable]
        private class Wrapper<T>
        {
            public T[] array;
        }
    }
}
