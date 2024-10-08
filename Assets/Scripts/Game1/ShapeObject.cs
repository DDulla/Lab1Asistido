using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeObject : MonoBehaviour
{
    public ColorShapeData shapeData;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerColorShapeController playerController = other.GetComponent<PlayerColorShapeController>();
            if (playerController != null)
            {
                playerController.ChangeShape(shapeData);
            }
        }
    }
}

