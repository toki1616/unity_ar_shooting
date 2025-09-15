using UnityEngine;
using Zenject;

public class TimeLimitInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Debug.Log("TimeLimitInstaller run");

        //Presenter
        Container.Bind<TimeLimitPresenter>().AsSingle();
        
        //Model
        Container.Bind<TimeLimitModel>().AsSingle();
    }
}