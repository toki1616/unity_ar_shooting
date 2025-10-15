using UnityEngine;
using System.Collections.Generic;
using Zenject;

public class EnemyInstaller : MonoInstaller
{
    [SerializeField]
    private Transform spawnRoot;

    [SerializeField]
    private GameObject CubePrefab;
    
    [SerializeField]
    private GameObject SpherePrefab;
    
    [SerializeField]
    private GameObject CylinderPrefab;
    
    [SerializeField]
    private GameObject CapsulePrefab;
    
    public override void InstallBindings()
    {
        Debug.Log("EnemyInstaller run");
        
        Container.Bind<Transform>().WithId("SpawnRoot").FromInstance(spawnRoot).AsSingle();
        
        //Factory
        var prefabDict = new Dictionary<EnemyConst.EnemyType, GameObject>
        {
            { EnemyConst.EnemyType.Cube, CubePrefab },
            { EnemyConst.EnemyType.Sphere, SpherePrefab },
            { EnemyConst.EnemyType.Cylinder, CylinderPrefab },
            { EnemyConst.EnemyType.Capsule, CapsulePrefab },
        };

        Container.Bind<EnemyFactory>().AsSingle().WithArguments(prefabDict);

        //Presenter
        Container.Bind<EnemyViewModel>().AsSingle();
    }
}