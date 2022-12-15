using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseСlicksUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textPlayerClicks ;

    private int _numberOfClicks;
    
    public void ClicksCounter(int numberOfClicks)
    {
        _numberOfClicks = numberOfClicks;
    }
    private void Update()
    {
        _textPlayerClicks.text = _numberOfClicks.ToString();
    }
}
