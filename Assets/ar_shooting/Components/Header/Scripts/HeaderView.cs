using UnityEngine;
using Zenject;
using R3;

public class HeaderView : MonoBehaviour
{
    private GameViewModel _gamePresenter;

    [Inject]
    public void Construct
        (
            GameViewModel gamePresenter
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
