using R3;
using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    private ClockView clockViewTH;
    [SerializeField]
    private ClockView clockViewZA;
    [SerializeField]
    private ClockView clockViewUK;

    private ClockViewModel viewModel;

    void Start()
    {
        viewModel = new ClockViewModel();

        clockViewTH.Init(viewModel.CurrentTime
            .Select(x => TimeSpan.FromSeconds(x).Add(TimeSpan.FromHours(7))
            ));

        clockViewUK.Init(viewModel.CurrentTime
            .Select(x => TimeSpan.FromSeconds(x)));

        clockViewZA.Init(viewModel.CurrentTime
            .Select(x => TimeSpan.FromSeconds(x).Add(TimeSpan.FromHours(2))
            ));
    }
}
