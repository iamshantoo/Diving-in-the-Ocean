using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SharkDetector : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Shark"))
        {
            Destroy(this.gameObject);
            EndGame();
        }
    }

    void EndGame()
    {
        gameOverPanel.SetActive(true);
        Debug.Log("Game Over!");
    }
}
