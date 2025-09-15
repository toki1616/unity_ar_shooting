using UnityEngine;
using UnityEngine.UI;
using R3;
using Zenject;

public class TimeLimitView : MonoBehaviour
{
    private TimeLimitPresenter _timeLimitPresenter;
    private GamePresenter _gamePresenter;

    [Inject]
    public void Construct
        (
            TimeLimitPresenter timeLimitPresenter,
            GamePresenter gamePresenter
        )
    {
        Debug.Log("TimeLimitView : Inject");
        _timeLimitPresenter = timeLimitPresenter;
        _gamePresenter = gamePresenter;
    }
    
    [SerializeField] 
    private Text timerText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _timeLimitPresenter.remainingTimeAsObservable.Subscribe(_ => UpdateTimer(_)).AddTo(this);
        _timeLimitPresenter.OnTimeUpAsObservable.Subscribe(_ => OnTimeUp()).AddTo(this);
    }
    
    public void UpdateTimer(float time) {
        timerText.text = $"{time}";
    }
    
    public void OnTimeUp()
    {
        _gamePresenter.UpdateGameStatus(GameConstantsConst.GameStatus.End);
    }
}
