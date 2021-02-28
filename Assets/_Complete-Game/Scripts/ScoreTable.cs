using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTable
{
    private List<ScorePlayer> listPlayers;
    private int showPlayers = 10;


    public void LoadPlayers()
    {
        listPlayers = new List<ScorePlayer>(); //Сюда будут грузиться статистика игроков
        ShowTable();
    }

    private void ShowTable()
    {
        listPlayers.Sort(new ScorePlayerComparerDays());
        //реализовать отрисовку
    }
}

//Сюда дописывать статистику игроков
public class ScorePlayer
{
    public string name;
    public int days;
    public int foodEating;
}

//Тут задать правила сортировки
class ScorePlayerComparerDays : IComparer<ScorePlayer>
{
    public int Compare(ScorePlayer p1, ScorePlayer p2)
    {
        if (p1.days > p2.days)
            return 1;
        else if (p1.days < p2.days)
            return -1;
        else
            return 0;
    }
}

class ScorePlayerComparerFoods : IComparer<ScorePlayer>
{
    public int Compare(ScorePlayer p1, ScorePlayer p2)
    {
        if (p1.foodEating > p2.foodEating)
            return 1;
        else if (p1.foodEating < p2.foodEating)
            return -1;
        else
            return 0;
    }
}