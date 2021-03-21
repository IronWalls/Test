using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Completed
{
    public class FoodController : MonoBehaviour
    {
        public Text foodCapText;
        public Slider foodBar;
        private void Start()
        {
            foodCapText.text = GameManager.instance.GameMode.foodCapMessage;
            foodBar.value = GameManager.instance.GameMode.playerFoodPoints;
            foodBar.maxValue = GameManager.instance.GameMode.playerFoodPoints;
        }

        private void OnEnable()
        {
            Player.CheckingFoodCap += ProvideFoodCapMessage;
            Player.FoodBarTracker += ChangeBarStatus;
        }
        private void OnDisable()
        {
            Player.CheckingFoodCap -= ProvideFoodCapMessage;
            Player.FoodBarTracker -= ChangeBarStatus;
        }

        void ProvideFoodCapMessage()
        {
            StartCoroutine(CallCapText());
        }

        void ChangeBarStatus(int currenFood)
        {
            foodBar.value = currenFood;
        }

        public IEnumerator CallCapText()
        {
            foodCapText.gameObject.SetActive(true);
            yield return new WaitForSeconds(2f);
            foodCapText.gameObject.SetActive(false);
        }
    }
}

