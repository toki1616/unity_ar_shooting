using UnityEngine;
using Zenject;

public class ScoreInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("ScoreInstaller run");

        //Presenter
        Container.Bind<ScoreViewModel>().AsSingle();
        
        //Model
        //Container.Bind<ScoreModel>().AsSingle();
    }
}