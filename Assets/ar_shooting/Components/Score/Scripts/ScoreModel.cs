using UnityEngine;
using R3;

public class ScoreModel
{
    private readonly ReactiveProperty<float> _score = new ReactiveProperty<float>();
    public ReadOnlyReactiveProperty<float> score => _score;
    
    public void AddScore(ScoreConst.ScoreEvent scoreEvent)
    {
        Debug.Log($"ScoreModel : AddScore : {scoreEvent.GetValueScore()}");
        float score = _score.Value + scoreEvent.GetValueScore();
        _score.Value = score;
    }
    
     public void ResetScore()
    {
        _score.Value = 0;
    }
}
