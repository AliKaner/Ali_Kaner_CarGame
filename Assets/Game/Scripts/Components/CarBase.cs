using UnityEngine;

public class CarBase : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private bool isGameStarted;

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void Initialize()
    {
        isGameStarted = false;
    }
    public void StartGame()
    {
        isGameStarted = true;
    }

    private void Update()
    {
        if (!isGameStarted) return;
        MoveForward();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.collider.tag)
        {
            case "Obstacle":
            case "Car":
                //GameManager.Instance.Lose();
                break;

            case "Finish":
                //GameManager.Instance.Win();
                break;
        }
    }
}