using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class FoodBar : MonoBehaviour
{
    [HideInInspector]
    public int MaxFood;
    public Gradient gradient;
    public Image Fill;
    private Slider bar => GetComponent<Slider>();
    public Text foodValue;

    public void Init(int curValue,int maxValue)
    {
        MaxFood = maxValue;
        bar.maxValue = maxValue;
        UpdateData(curValue);
        transform.SetAsFirstSibling();
    }

    public void UpdateData(int curValue)
    {    
        bar.value = curValue;
        foodValue.text = bar.value.ToString();
        Fill.color = gradient.Evaluate((float)curValue / (float)MaxFood);
    }
}
