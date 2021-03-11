using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class GameMessage : MonoBehaviour
{
    [Serializable]
    public struct Message
    {
        public MessageType type;
        public string message;
        public int showTime;
    }

    public enum MessageType
    {
        FoodLimit
    }

    public Message[] messages;

    public void ShowMessage(MessageType messageType)
    {
        try
        {
            var matchingMessages = Array.FindAll(messages, m => m.type == messageType);
            var message = matchingMessages[UnityEngine.Random.Range(0, matchingMessages.Length)];
            GetComponent<Text>().text = message.message;
            Destroy(gameObject, message.showTime);
        }
        catch
        {
            Debug.LogError("No message of this type found");
            Destroy(gameObject);
        }
    }
}
