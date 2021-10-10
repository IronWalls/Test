using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Completed;
using UnityEngine;
using UnityEngine.UI;

public class TrashBox : MonoBehaviour
{
    [SerializeField] private Text m_foodText;
    [SerializeField] private Slider m_foodSlider;

    private void OnTriggerEnter(Collider other)
    {
        var item = other.gameObject.GetComponentInParent<MoveController>();
        if (item)
        {
            Destroy(item.gameObject);
        }
    }
}