using UnityEngine;
using R3;

public class TimeLimitViewModel
{
    private readonly TimeLimitModel _timeLimitModel;
    
    public TimeLimitViewModel(TimeLimitModel timeLimitModel)
    {
        Debug.Log("TimeLimitViewModel : Inject");
        
        _timeLimitModel = timeLimitModel;
    }
    
    public Observable<float> remainingTimeAsObservable => 
        _timeLimitModel.RemainingTime
        .Publish()
        .RefCount();
        
    // 時間切れの通知
    public Observable<Unit> OnTimeUpAsObservable => 
        _timeLimitModel.OnTimeUp
        .Publish()
        .RefCount();
}
