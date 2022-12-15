using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorProvider : MonoBehaviour
{
    [SerializeField] public Color[] _colors;

    public Color GetColor()
    {
        var index = Random.Range(0, _colors.Length);
        return _colors[index];
    }
}
    
     