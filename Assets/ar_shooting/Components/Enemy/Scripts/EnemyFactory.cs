using UnityEngine;
using Zenject;
using System.Collections.Generic;

public class EnemyFactory
{
    private readonly Dictionary<EnemyConst.EnemyType, GameObject> _enemyPrefabs;
    private readonly Transform _spawnRoot;
    private readonly DiContainer _container;

    public EnemyFactory
    (
        Dictionary<EnemyConst.EnemyType, GameObject> enemyPrefabs,
        [Inject(Id = "SpawnRoot")] Transform spawnRoot,
        DiContainer container
    )
    {
        _enemyPrefabs = enemyPrefabs;
        _spawnRoot = spawnRoot;
        _container = container;
    }

    public GameObject Create(EnemyConst.EnemyType type, Vector3 position)
    {
        if (!_enemyPrefabs.ContainsKey(type))
        {
            Debug.LogError($"EnemyType {type} に対応するプレハブがありません");
            return null;
        }

        var prefab = _enemyPrefabs[type];
        return _container.InstantiatePrefab(prefab, position, Quaternion.identity, _spawnRoot);
    }
}


