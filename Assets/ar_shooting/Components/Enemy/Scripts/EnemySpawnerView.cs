using UnityEngine;
using R3;
using Zenject;

public class EnemySpawnerView : MonoBehaviour
{
    private EnemyViewModel _enemyPresenter;

    [Inject]
    public void Construct
        (
            EnemyViewModel enemyPresenter
        )
    {
        Debug.Log("EnemySpawnerView : Inject");
        _enemyPresenter = enemyPresenter;
    }

    [SerializeField]
    private GameObject enemyPrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // 初回5体生成
        for (int i = 0; i < GameConstantsConst.initialSpawnEnemyCount; i++)
        {
            SpawnEnemy();
        }

        // 1秒ごとに1体生成（UniRx）
        Observable.Interval(System.TimeSpan.FromSeconds(GameConstantsConst.spawnEnemyInterval))
            .Subscribe(_ => SpawnEnemy())
            .AddTo(this); // Viewが破棄されたら自動Dispose
    }
    
    private void SpawnEnemy()
    {
        _enemyPresenter.SpawnEnemyAroundCamera(enemyPrefab);
    }
}
