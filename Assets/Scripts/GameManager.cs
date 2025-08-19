using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int points = 0;

    public int AddPoints(int earnt)
    {
        points += earnt;

        return points;
    }

    public void PrintPoints()
    {
        Debug.Log("Points = " + points);
    }
}
