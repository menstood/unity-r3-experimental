using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using R3;
using System;

public class ClockView : MonoBehaviour
{
    [SerializeField]
    private Text timeText;

    public void Init(Observable<TimeSpan> timeObservable)
    {
        timeObservable
            .Subscribe(t =>
        {
            timeText.text =  t.ToString(@"hh\:mm\:ss"); 
        });
    }
}
