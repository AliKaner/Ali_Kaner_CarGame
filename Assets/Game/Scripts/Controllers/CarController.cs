using UnityEngine;

public class CarController : MonoBehaviour
{
    public Transform playersCar;

    [SerializeField]
    private float speed;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void TurnLeft()
    {
        playersCar.Rotate(0, -speed, 0);
    }

    public void RightLeft()
    {
        playersCar.Rotate(0, -speed, 0);
    }
}