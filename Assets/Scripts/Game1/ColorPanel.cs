using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPanel : MonoBehaviour
{
    public Image colorDisplay;
    public PlayerColorShapeController playerController;

    private void Update()
    {
        colorDisplay.color = playerController.spriteRenderer.color;
    }
}




