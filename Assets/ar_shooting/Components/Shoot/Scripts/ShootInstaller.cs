using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class ShootInstaller : MonoInstaller
{
    [SerializeField]
    private GameObject ballPrefab;
    
    public override void InstallBindings()
    {
        Debug.Log("ShootInstaller run");

        //Presenter
        Container.Bind<ShootViewModel>().AsSingle().WithArguments(ballPrefab);
    }
}