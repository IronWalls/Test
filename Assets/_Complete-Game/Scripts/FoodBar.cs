using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
	public GameObject Target;
    private Image image;

	private void Start()
	{
		image = gameObject.GetComponent<Image>();
	}

	private void Update()
	{
		var playerOnScreen = Camera.main.WorldToScreenPoint(Target.transform.localPosition);
		transform.localPosition = new Vector3( playerOnScreen.x, playerOnScreen.y, 0) + new Vector3(0, 10, 0);
	}

	public void SetBar(int MaxBar, int value)
	{
		image.fillAmount = (float)value /(float)MaxBar;
	}
}
