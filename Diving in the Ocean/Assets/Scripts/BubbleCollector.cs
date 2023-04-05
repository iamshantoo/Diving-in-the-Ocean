using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCollector : MonoBehaviour
{
    private BubbleCounter bubbleCounter;

    void Start()
    {
        bubbleCounter = FindObjectOfType<BubbleCounter>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            Destroy(other.gameObject);
            bubbleCounter.AddBubble();
        }
    }
}
