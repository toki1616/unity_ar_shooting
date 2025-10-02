using UnityEngine;
using UnityEngine.UI;
using R3;
using Zenject;

public class ScoreView : MonoBehaviour
{
    private ScoreViewModel _scorePresenter;

    [Inject]
    public void Construct
        (
            ScoreViewModel scorePresenter
        )
    {
        Debug.Log("ScoreView : Inject");
        _scorePresenter = scorePresenter;
    }

    [SerializeField]
    private Text scoreText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _scorePresenter.scoreAsObservable.Subscribe(_ => ReceivedScore(_)).AddTo(this);
    }
    
    private void ReceivedScore(float score)
    {
        scoreText.text = $"{score}";
    }
}
