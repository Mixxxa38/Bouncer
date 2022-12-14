using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
   private Renderer _cubeColor;
  
   private void Start()
   {
       _cubeColor = GetComponent<Renderer>();
   }
    private void OnCollisionEnter(Collision collision)
    {
     if (collision.gameObject.CompareTag("Player"))
     {
        var color = collision.gameObject.GetComponent<Renderer>();
        if (color.material.color == _cubeColor.material.color)
        {
            Destroy(gameObject);
        }
     }
    }
}
