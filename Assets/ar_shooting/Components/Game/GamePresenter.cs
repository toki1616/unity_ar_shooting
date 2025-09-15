using UnityEngine;
using R3;

public class GamePresenter
{
    private GameModel _gameModel;
    public GamePresenter(GameModel gameModel)
    {
        _gameModel = gameModel;
    }
    
    public Observable<GameConstantsConst.GameStatus> gameStatusAsObservable => 
        _gameModel.GameStatus
        .Publish()
        .RefCount();
        
    public void UpdateGameStatus(GameConstantsConst.GameStatus gameStatus)
    {
        _gameModel.UpdateGameStatus(gameStatus);
    }
}
