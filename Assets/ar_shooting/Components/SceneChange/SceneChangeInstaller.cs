using UnityEngine;
using Zenject;

public class SceneChangeInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Model
        Container.Bind<SceneChangeModel>().AsSingle();
        
        //Presenter
        Container.Bind<SceneChangeViewModel>().AsSingle();
    }
}