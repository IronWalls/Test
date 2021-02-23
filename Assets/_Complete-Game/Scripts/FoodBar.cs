using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Completed;

public class FoodBar : MonoBehaviour
{
    public Slider slider;

    public void UpdateBar(int currentFood) 
    {
        float foodPercentage = (float)currentFood / (float)GameManager.instance.gameMode.foodCap;
        Debug.Log(foodPercentage);

        slider.value = foodPercentage;
    }
}