using UnityEditor;
using UnityEngine;

public class EnemyPresenter
{
    private readonly EnemyFactory _enemyFactory;
    
    public EnemyPresenter(EnemyFactory enemyFactory)
    {
        Debug.Log("EnemyPresenter : Inject");
        
        _enemyFactory = enemyFactory;
    }
    
    public void SpawnEnemyAroundCamera(GameObject enemyPrefab)
    {
        Vector3 cameraPos = Camera.main.transform.position;

        // ランダムな方向（球状）
        Vector3 randomDirection = Random.insideUnitSphere.normalized;

        // ランダムな距離（3m〜5m）
        float randomDistance = Random.Range(GameConstantsConst.EnemySpawnMinDistance, GameConstantsConst.EnemySpawnMaxDistance);

        // 位置を計算（球状範囲）
        Vector3 spawnPos = cameraPos + randomDirection * randomDistance;

        // 敵を出現
        EnemyConst.EnemyType type = GetRandomType();
        _enemyFactory.Create(type, spawnPos);
    }
    
    private EnemyConst.EnemyType GetRandomType()
    {
        var values = System.Enum.GetValues(typeof(EnemyConst.EnemyType));
        return (EnemyConst.EnemyType)values.GetValue(Random.Range(0, values.Length));
    }

    private Vector3 GetRandomPosition()
    {
        Vector2 dir = Random.insideUnitCircle.normalized;
        float dist = Random.Range(3f, 5f);
        return Camera.main.transform.position + new Vector3(dir.x, 0, dir.y) * dist;
    }
}