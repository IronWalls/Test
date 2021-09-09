using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private Slider slider;

    [SerializeField] private IntVariable valueVariable;

    [SerializeField] private IntVariable maxValueVariable;


    private void Update()
    {
        slider.value = valueVariable.value;
        slider.maxValue = maxValueVariable.value;
    }
}
