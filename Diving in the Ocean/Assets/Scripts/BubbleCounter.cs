using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubbleCounter : MonoBehaviour
{
    public TextMeshProUGUI bubbleText;
    private int bubbleCount = 0;

    void Update()
    {
        bubbleText.text = "Bubbles: " + bubbleCount;
    }

    public void AddBubble()
    {
        bubbleCount++;
    }
}
