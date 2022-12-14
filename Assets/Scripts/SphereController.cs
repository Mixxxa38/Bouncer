using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereController: MonoBehaviour
{
    private ColorProvider _colorProvider;
    private Renderer _sphere;
    
    private void Start()
    {
       _sphere = GetComponent<Renderer>();
       SphereInstantiate();
    }
    
    public void SphereInstantiate()
    {
        _sphere.transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 0.8f,Random.Range(-9.5f, 9.5f));
        _colorProvider = FindObjectOfType<ColorProvider>();
        _sphere.GetComponent<Renderer>().material.color = _colorProvider.GetColor();
    }
    
   private void OnCollisionEnter(Collision collision)
   {
       if (collision.gameObject.CompareTag("Player"))
       {
           var playerColor = collision.gameObject.GetComponent<Renderer>();
           playerColor.material.color = _sphere.material.color;
           SphereInstantiate();
       }
   }
}
