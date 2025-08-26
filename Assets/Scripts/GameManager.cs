using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int points = 0;
    public TMP_Text pointsText;
    public TMP_Text speedText;
    Rigidbody playerRb;

    public void Start()
    {
        MarbleController marble = FindFirstObjectByType<MarbleController>();
        playerRb = marble.GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (speedText != null)
        {
            // Vector3 -> X, Y , Z -> magnitude = float "length of the vector"  -> 2 decimal places
            speedText.text = "Speed: " + playerRb.linearVelocity.magnitude.ToString("F2");
        }
    }

    public int AddPoints(int earnt)
    {
        points += earnt;
        if (pointsText != null)
        {
            pointsText.text = "Score: " + points;
        }
        return points;
    }

    public void PrintPoints()
    {
        Debug.Log("Points = " + points);
    }
}
