using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorShapeData", menuName = "ScriptableObjects/Game1/ColorShapeData")]
public class ColorShapeData : ScriptableObject
{
    public Color color;
    public Sprite sprite;
}