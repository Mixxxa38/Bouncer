using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{ 
    [SerializeField] private float _force = 38f;
    
    private MouseСlicksUI _mouseСlicksUI;
    private int _clicks;
    private Rigidbody _rigidbody;
    private Vector3 _target;
    private Vector3 _startPosition = new (0, 0.7f, 0);
   

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mouseСlicksUI = FindObjectOfType<MouseСlicksUI>();
    }
    
    private void Update()
    {
        if (transform.position.y < -1)
        {
            transform.position = _startPosition;
        }
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out var hitInfo))
        {
           _rigidbody.velocity = Vector3.zero;
           MoveTowardsSelectedPoint(hitInfo);
           
           _clicks++;
           _mouseСlicksUI.ClicksCounter(_clicks);
        }
    }
    private void MoveTowardsSelectedPoint(RaycastHit hitInfo)
    {
        var direction = (hitInfo.point - transform.position).normalized;
        _rigidbody.AddForce(new Vector3(direction.x, 0, direction.z) * _force);
    }
}

