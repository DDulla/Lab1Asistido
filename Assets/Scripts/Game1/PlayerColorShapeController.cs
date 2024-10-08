using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorShapeController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeColor(ColorShapeData colorData)
    {
        spriteRenderer.color = colorData.color;
    }

    public void ChangeShape(ColorShapeData shapeData)
    {
        spriteRenderer.sprite = shapeData.sprite;
    }
}

