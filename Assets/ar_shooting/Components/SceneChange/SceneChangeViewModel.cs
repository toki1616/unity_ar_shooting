using UnityEngine;

public class SceneChangeViewModel
{
    private readonly SceneChangeModel _sceneChangeModel;
    
    public SceneChangeViewModel(SceneChangeModel sceneChangeModel)
    {
        _sceneChangeModel = sceneChangeModel;
    }
    
    public void ChangeScene(GameConstantsConst.GameStatus gameStatus)
    {
        _sceneChangeModel.ChangeScene(gameStatus);
    }
}
