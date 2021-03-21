using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Completed
{
    public class FoodController : MonoBehaviour
    {
        public Text foodCapText;
        private void Start()
        {
            foodCapText.text = GameManager.instance.GameMode.foodCapMessage;
        }

        private void OnEnable()
        {
            Player.CheckingFood += ProvideFoodCapMessage;
        }
        private void OnDisable()
        {
            Player.CheckingFood -= ProvideFoodCapMessage;
        }

        void ProvideFoodCapMessage(int currentFood)
        {
            StartCoroutine(CallCapText());
        }

        public IEnumerator CallCapText()
        {
            foodCapText.gameObject.SetActive(true);
            yield return new WaitForSeconds(2f);
            foodCapText.gameObject.SetActive(false);
        }
    }
}

