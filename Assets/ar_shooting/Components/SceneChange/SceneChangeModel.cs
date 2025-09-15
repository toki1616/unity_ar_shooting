using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeModel
{
    public void ChangeScene(GameConstantsConst.GameStatus gameStatus)
    {
        switch(gameStatus)
        {
            case GameConstantsConst.GameStatus.Start:
                SceneManager.LoadScene("TitleScene");
                break;
                
            case GameConstantsConst.GameStatus.Game:
                SceneManager.LoadScene("ARShootingScene");
                break;
            
            case GameConstantsConst.GameStatus.End:
                SceneManager.LoadScene("ResultScene");
                break;
        }
    }
}
