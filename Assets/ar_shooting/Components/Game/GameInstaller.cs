using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Model
        Container.Bind<GameModel>().AsSingle();
        
        //Presenter
        Container.Bind<GamePresenter>().AsSingle();
    }
}
