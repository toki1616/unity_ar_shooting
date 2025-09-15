using UnityEngine;
using R3;

public class ScorePresenter
{
    private readonly ScoreModel _scoreModel;
    
    public ScorePresenter(ScoreModel scoreModel)
    {
        Debug.Log("ScorePresenter : Inject");
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
