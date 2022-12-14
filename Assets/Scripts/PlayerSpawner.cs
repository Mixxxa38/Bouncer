using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    private  Vector3 _startPosition = new (0, 0.7f, 0);
   
    private void Start()
    {
        var newCube = Instantiate(_cubePrefab);
        newCube.transform.position = _startPosition;
        newCube.GetComponent<Renderer>().material.color = Color.white;
    }
}
