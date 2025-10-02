using UnityEngine;
using Zenject;

public class EnemyHitDetectorView : MonoBehaviour
{
    private ScoreViewModel _scorePresenter;

    [Inject]
    public void Construct
        (
            ScoreViewModel scorePresenter
        )
    {
        Debug.Log("EnemyHitDetectorView : Inject");
        _scorePresenter = scorePresenter;
    }

    [SerializeField]
    private ScoreConst.ScoreEvent scoreEvent;
    
    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("EnemyHitDetectorView Trigger hit: " + collider.name);
        // 衝突イベントを通知
        Destroy(collider);
    }
    
    private void Destroy(Collider collider)
    {
        if (collider.tag == GameConstantsConst.ARShootingTag.Bullet.GetValueString())
        {
            _scorePresenter.AddScore(scoreEvent);
            Destroy(gameObject);
        }
        else if (collider.tag == GameConstantsConst.ARShootingTag.Player.GetValueString())
        {
            Destroy(gameObject);
        }
    }
}
