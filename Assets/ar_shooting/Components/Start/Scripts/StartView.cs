using UnityEngine;
using UnityEngine.UI;
using Zenject;
using R3;

public class StartView : MonoBehaviour
{
    private GamePresenter _gamePresenter;

    [Inject]
    public void Construct
        (
            GamePresenter gamePresenter
        )
    {
        Debug.Log("StartView : Inject");
        _gamePresenter = gamePresenter;
    }

    [SerializeField]
    private GameObject parentUI;
    
    [SerializeField]
    private Button startButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton.onClick.AsObservable().Subscribe(_ => OnClickStart()).AddTo(this);
    }
    
    private void OnClickStart()
    {
        _gamePresenter.UpdateGameStatus(GameConstantsConst.GameStatus.Game);
    }
}
