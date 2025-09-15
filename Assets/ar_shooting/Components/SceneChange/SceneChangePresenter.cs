using UnityEngine;

public class SceneChangePresenter
{
    private readonly SceneChangeModel _sceneChangeModel;
    
    public SceneChangePresenter(SceneChangeModel sceneChangeModel)
    {
        _sceneChangeModel = sceneChangeModel;
    }
    
    public void ChangeScene(GameConstantsConst.GameStatus gameStatus)
    {
        _sceneChangeModel.ChangeScene(gameStatus);
    }
}
