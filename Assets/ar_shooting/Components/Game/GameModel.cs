using UnityEngine;
using R3;

public class GameModel {
    private SceneChangePresenter _sceneChangePresenter;
    
    public GameModel(SceneChangePresenter sceneChangePresenter)
    {
        Debug.Log("GameModel : Inject");
        
        _sceneChangePresenter = sceneChangePresenter;
    }
    private readonly CompositeDisposable _disposables = new CompositeDisposable();

    private void HandleTimeUp() {
        // ゲームオーバー処理や状態遷移など
        UpdateGameStatus(GameConstantsConst.GameStatus.End);
    }

    public void Dispose() {
        _disposables.Dispose();
    }
    
    private readonly ReactiveProperty<GameConstantsConst.GameStatus> _gameStatus = new ReactiveProperty<GameConstantsConst.GameStatus>(GameConstantsConst.GameStatus.Start);
    public ReadOnlyReactiveProperty<GameConstantsConst.GameStatus> GameStatus => _gameStatus;
    
    public void UpdateGameStatus(GameConstantsConst.GameStatus gameStatus)
    {
        _gameStatus.Value = gameStatus;
        _sceneChangePresenter.ChangeScene(gameStatus);
    }
}
