using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cylinderPrefab;
    private ColorProvider _colorProvider;
    private int _numberOfCylinders = 6;
  
    private void Start()
    {
        for (int i = 0; i < _numberOfCylinders; i++)
        {
            var newCylinder = Instantiate(_cylinderPrefab);
            newCylinder.transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 0.85f,Random.Range(-9.5f, 9.5f));
            _colorProvider = FindObjectOfType<ColorProvider>();
            newCylinder.GetComponent<Renderer>().material.color = _colorProvider.GetColor();
        }
    }
}
