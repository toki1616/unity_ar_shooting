using UnityEngine;
using Zenject;
using R3;

public class HeaderView : MonoBehaviour
{
    private GamePresenter _gamePresenter;

    [Inject]
    public void Construct
        (
            GamePresenter gamePresenter
        )
    {
        Debug.Log("HeaderView : Inject");
        _gamePresenter = gamePresenter;
    }
    
    [SerializeField]
    private GameObject parentUI;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
}
