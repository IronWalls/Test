using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
	public GameObject Target; // Target gameobject player
    public Image image; 

	private void Update()
	{
		// Purpose following
		var playerOnScreen = Camera.main.WorldToScreenPoint(Target.gameObject.transform.position);
		transform.position = new Vector3( playerOnScreen.x, playerOnScreen.y, 0) + new Vector3(0, 50, 0);
	}

	// Setting up a food bar
	public void SetBar(int MaxBar, int value)
	{
		image.fillAmount = (float)value /(float)MaxBar;
	}
}
