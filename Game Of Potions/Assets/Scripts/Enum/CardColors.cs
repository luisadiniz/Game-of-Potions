using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardColors
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    public static Color GetColor(Colors colors)
    {
        Color _color = new Color();
        switch (colors)
        {
            case Colors.Red:
                _color = Color.red;
                break;
            case Colors.Green:
                _color = Color.green;
                break;
            case Colors.Blue:
                _color = Color.blue;
                break;
        }
        return _color;
    }

    
}
