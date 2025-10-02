using UnityEngine;
using R3;

public class ScoreViewModel
{
    private readonly ScoreModel _scoreModel;
    
    public ScoreViewModel(ScoreModel scoreModel)
    {
        Debug.Log("ScoreViewModel : Inject");
        _scoreModel = scoreModel;
    }
    
    //AddScore
    public void AddScore(ScoreConst.ScoreEvent scoreEvent)
    {
        _scoreModel.AddScore(scoreEvent);
    }
    
    public void ResetScore()
    {
        _scoreModel.ResetScore();
    }
    
    public Observable<float> scoreAsObservable => 
        _scoreModel.score
        .Publish()
        .RefCount();
}
