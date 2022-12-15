using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cylinderPrefab;
    
    private ColorProvider _colorProvider;
    private int _numberOfCylinders = 6;
    private CylinderColorCounter _cylinderColorCounter;
    private int _indexColor;
    
    private void Start()
    {
        _colorProvider = FindObjectOfType<ColorProvider>();
        _cylinderColorCounter = FindObjectOfType<CylinderColorCounter>();
        for (int i = 0; i < _numberOfCylinders; i++)
        {
            var newCylinder = Instantiate(_cylinderPrefab);
            newCylinder.transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 0.85f,Random.Range(-9.5f, 9.5f));
            newCylinder.GetComponent<Renderer>().material.color = _colorProvider.GetColor();
            
            if (newCylinder.GetComponent<Renderer>().material.color == _colorProvider._colors[0])
            {
                _indexColor = 0;
            }
            if (newCylinder.GetComponent<Renderer>().material.color == _colorProvider._colors[1])
            {
                _indexColor = 1;
            }
            if (newCylinder.GetComponent<Renderer>().material.color == _colorProvider._colors[2])
            {
                _indexColor = 2;
            }
            _cylinderColorCounter.WhichCylinderColor(_indexColor);
        }
    }
}
