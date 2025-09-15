public static class GameConstantsConst
{
    public const float GameTime = 10;

    // 敵のスポーン距離範囲（カメラから）
    public const float EnemySpawnMinDistance = 7f;
    public const float EnemySpawnMaxDistance = 10f;

    //敵の初期スポーン数
    public const int initialSpawnEnemyCount = 20;

    //敵のスポーン間隔
    public const float spawnEnemyInterval = 0.5f;
    
    // 弾の削除距離（カメラから）
    public const float BulletDestroyDistance = EnemySpawnMaxDistance;
    
    public enum ARShootingTag
    {
        Enemy,
        Bullet,
        Player
    }
    
    public enum GameStatus
    {
        Start,
        Game,
        End,
    }
}
