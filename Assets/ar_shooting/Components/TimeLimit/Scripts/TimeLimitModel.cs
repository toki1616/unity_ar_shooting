using UnityEngine;
using System;
using R3;

public class TimeLimitModel
{   
    public TimeLimitModel() {
        StartCountDown();
    }
    
    private readonly ReactiveProperty<float> _remainingTime = new ReactiveProperty<float>(GameConstantsConst.GameTime);
    public ReadOnlyReactiveProperty<float> RemainingTime => _remainingTime;
    
    private readonly float _interval = 0.1f;
    private void StartCountDown()
    {
        int totalTicks = Mathf.CeilToInt(GameConstantsConst.GameTime / _interval);
        Observable.Interval(TimeSpan.FromSeconds(_interval))
            .Take(totalTicks)
            .Subscribe(_ => {
                _remainingTime.Value = Mathf.Max(0f, Mathf.Round((_remainingTime.Value - _interval) * 10f) / 10f);
            });
    }
    
    public Observable<Unit> OnTimeUp => _remainingTime
        .Where(time => time <= 0f)
        .Take(1)
        .Do(_ => Debug.Log("制限時間が0になりました！"))
        .AsUnitObservable();
}
