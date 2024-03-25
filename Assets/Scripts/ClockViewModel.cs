using R3;
using System;

public class ClockViewModel 
{

    public ReactiveProperty<double> CurrentTime { get; private set; }
    public ClockViewModel()
    {
        var span = DateTime.UtcNow.TimeOfDay;
        CurrentTime = new ReactiveProperty<double>(span.TotalSeconds);
        Observable.Interval(TimeSpan.FromSeconds(1))
            .Subscribe(_ =>
            {
                span = DateTime.UtcNow.TimeOfDay;
                CurrentTime.Value = span.TotalSeconds;
            });
    }

}
