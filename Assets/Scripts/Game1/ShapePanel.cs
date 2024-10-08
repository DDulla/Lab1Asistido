using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapePanel : MonoBehaviour
{
    public Image shapeDisplay;

    public void UpdateShape(ColorShapeData shapeData)
    {
        shapeDisplay.sprite = shapeData.sprite;
    }
}

