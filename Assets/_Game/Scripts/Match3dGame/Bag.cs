using System.Collections;
using System.Collections.Generic;
using Completed;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    [SerializeField] private Text m_foodText;
    [SerializeField] private Slider m_foodSlider;

    private void OnTriggerEnter(Collider other)
    {
        var item = other.gameObject.GetComponentInParent<MoveController>();
        if (item)
        {
            var result = item.Type == MoveController.ObjectType.Trash ? -10 : 10;
            var newF = GameManager.instance.playerFoodPoints + result;
            GameManager.instance.playerFoodPoints =
                Mathf.Clamp(newF, int.MinValue, GameManager.instance.settings.PlayerFoodCap);

            m_foodSlider.value = (float) newF / GameManager.instance.settings.PlayerFoodCap;
            m_foodText.text = "Food: " + GameManager.instance.playerFoodPoints;

            Destroy(item.gameObject);
        }
    }
}