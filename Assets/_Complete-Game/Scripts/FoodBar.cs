using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
	// Start is called before the first frame update
	public Slider slider;
	public Gradient gradient;

	public void SetFoodCap(int foodCap)
	{
		slider.maxValue = foodCap;
	}

	public void SetHealth(int hefood)
	{
		slider.value = hefood;
	}
}
