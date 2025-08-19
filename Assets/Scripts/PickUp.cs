using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int points = 1;

    GameManager gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered Trigger Zone");

        Rigidbody playerRb = other.GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 300f);

        int total = gameManager.AddPoints(points);
        gameManager.PrintPoints();

        Destroy(gameObject);
    }
}
