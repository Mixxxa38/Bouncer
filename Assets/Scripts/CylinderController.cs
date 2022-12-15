using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
   private Renderer _cubeColor;
   private CylinderColorCounter _cylinderColorCounter;
  
   private void Start()
   {
       _cylinderColorCounter = FindObjectOfType<CylinderColorCounter>();
       _cubeColor = GetComponent<Renderer>();
   } 
   private void OnCollisionEnter(Collision collision)
   {
     if (collision.gameObject.CompareTag("Player"))
      {
        var color = collision.gameObject.GetComponent<Renderer>();
        if (color.material.color == _cubeColor.material.color)
        {
            _cylinderColorCounter.WhatColorWasTaken(_cubeColor.material.color);
            Destroy(gameObject);
        }
      }
   }
}
