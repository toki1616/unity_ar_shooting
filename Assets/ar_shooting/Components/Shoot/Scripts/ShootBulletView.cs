using UnityEngine;

public class ShootBulletView : MonoBehaviour
{
    void Update()
    {
        // カメラの位置を取得
        Vector3 cameraPos = Camera.main.transform.position;

        // 弾との距離を計算
        float distance = Vector3.Distance(transform.position, cameraPos);

        // 5m以上離れたら削除
        if (distance > GameConstantsConst.BulletDestroyDistance)
        {
            Destroy(gameObject);
        }
    }
    
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("ShootBulletView Trigger hit: " + collider.name);
        Destroy(collider);
    }
    
    private void Destroy(Collider collider)
    {
        if (collider.tag == GameConstantsConst.ARShootingTag.Enemy.GetValueString())
        {
            Destroy(gameObject);
        }
    }
}
