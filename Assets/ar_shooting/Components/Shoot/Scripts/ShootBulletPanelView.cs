using UnityEngine;
using UnityEngine.EventSystems;
using R3;
using R3.Triggers;
using Zenject;

public class ShootBulletPanelView : MonoBehaviour
{
    private ShootViewModel _shootPresenter;

    [Inject]
    public void Construct
        (
            ShootViewModel shootPresenter
        )
    {
        Debug.Log("ShootBulletPanelView : Inject");
        _shootPresenter = shootPresenter;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var eventTrigger = this.gameObject.AddComponent<ObservableEventTrigger>();
        // PointerDown
        eventTrigger
            .OnPointerDownAsObservable()
            .Subscribe(pointerEventData => OnPointerDown(pointerEventData))
            .AddTo(this);
    }

    private void OnPointerDown(PointerEventData pointerEventData)
    {
        //Debug.Log(pointerEventData.position);
        _shootPresenter.OnTapShoot();
    }
}
