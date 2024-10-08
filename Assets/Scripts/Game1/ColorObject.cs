using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour
{
    public ColorShapeData colorData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerColorShapeController playerController = other.GetComponent<PlayerColorShapeController>();
            if (playerController != null)
            {
                playerController.ChangeColor(colorData);
            }
        }
    }
}

