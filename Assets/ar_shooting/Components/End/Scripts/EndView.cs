using UnityEngine;
using UnityEngine.UI;
using R3;
using Zenject;

public class EndView : MonoBehaviour
{
    private GameViewModel _gamePresenter;
     private ScoreViewModel _scorePresenter;

    [Inject]
    public void Construct
        (
            GameViewModel gamePresenter,
            ScoreViewModel scorePresenter
        )
    {
        Debug.Log("EndView : Inject");
        _gamePresenter = gamePresenter;
        _scorePresenter = scorePresenter;
    }

    [SerializeField]
    private GameObject parentUI;
    
    [SerializeField]
    private Text scoreText;
    
    [SerializeField]
    private Button endButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endButton.onClick.AsObservable().Subscribe(_ => OnClickEnd()).AddTo(this);
    }
    
    private void OnClickEnd()
    {
        _gamePresenter.UpdateGameStatus(GameConstantsConst.GameStatus.Start);
        _scorePresenter.ResetScore();
    }
}
