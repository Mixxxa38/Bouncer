using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CylinderColorCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textRedCylindersCount ;
    [SerializeField] private TextMeshProUGUI _textYellowCylindersCount ;
    [SerializeField] private TextMeshProUGUI _textGreenCylindersCount ;

    private ColorProvider _colorProvider;

    private int _redCylindersAmount;
    private int _yellowCylindersAmount;
    private int _greenCylindersAmount;

    private void Start()
    {
        _colorProvider = FindObjectOfType<ColorProvider>();
    }

     public void WhichCylinderColor(int numberOfColor)
    {
        if (numberOfColor == 0)
        {
           _redCylindersAmount++;
        }
        if(numberOfColor == 1)
        {
           _yellowCylindersAmount++;
        }
        if(numberOfColor == 2)
        {
           _greenCylindersAmount++;
        }
    }
     
     public void WhatColorWasTaken(Color color)
     {
         if (color == _colorProvider._colors[0])
         {
            _redCylindersAmount--;
         }
         if (color == _colorProvider._colors[1])
         {
            _yellowCylindersAmount--;
         }
         if (color == _colorProvider._colors[2])
         {
            _greenCylindersAmount--;
         }
     }
     
    private void Update()
    {
        _textRedCylindersCount.text = _redCylindersAmount.ToString();
        _textYellowCylindersCount.text = _yellowCylindersAmount.ToString();
        _textGreenCylindersCount.text = _greenCylindersAmount.ToString();
    }
}
