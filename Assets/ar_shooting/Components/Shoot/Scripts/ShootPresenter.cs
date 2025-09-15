using UnityEngine;

public class ShootPresenter
{
    private readonly GameObject ballPrefab;

    public ShootPresenter(GameObject ballPrefab)
    {
        Debug.Log("ShootBallPresenter : Inject");
        this.ballPrefab = ballPrefab;
    }
    
    public float shootForce = 50f;
    public void OnTapShoot()
    {
        GameObject ball = GameObject.Instantiate(ballPrefab, Camera.main.transform.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(Camera.main.transform.forward * shootForce, ForceMode.Impulse);
    }
}
