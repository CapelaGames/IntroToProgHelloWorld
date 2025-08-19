using UnityEngine;

// Class: Contains your variables and functions, "Blueprint" -> House blueprint
// Object: The thing that the blueprint makes, -> Built house

// Variable: Stores your data
// Function / Method: Actions, where your runnable code lives

// public : Other classes can access this
// private : Other classes cannot access this
public class HelloWorld : MonoBehaviour
{
    //Other classes and inspector can access
    public float speed = 800f;
    // by default variable are private
    // Other classes cannot access
    // but inspector can access
    [SerializeField]
    private float speed2 = 50f;

    private void Start()
    {
        int x = 25;
        int y;
        y = 10;

        float answer = x / y; // + - * /
        // answer is 2

        // Debug.Log(answer.ToString());
        Debug.Log("The answer answer is " + answer);

        // Modulo (%)
        int modAns = x % y;

        Debug.Log("Modulo answer is " + modAns);

        // these 3 lines do the same thing
        // Increment
        x = x + 1;
        x += 1;
        x++;

        x -= 1;
        x--;

        x = x * 2;
        x *= 2;

        x /= 5;

        x %= 2;
        // These are all called Assignment operators

        // Boolean operators

        // if (x == y)// Equal to
        // if (x < y) // Less than
        // if (x <= y) // Less than OR equal to
        // if (x > y) // Greater than
        // if (x >= y) // Greater than OR equal to
        if (x != y) // NOT equal to
        {
            Debug.Log("do thing");
        }
        else
        {
            Debug.Log("FALSE!");
        }

        // Not(!)
        bool thisBool = true;
        bool otherBool = !thisBool;
        // ternary operator, dont worry about this one.
        // too advanced, int c = x == y ? 10 : 50;

        int a = 0;
        int b = 0;
        // Logical operators
        // if (x == y && a == b) // AND, both have to be true
        if (x == y || a == b) // OR, either can be true
        {

        }
        else
        {

        }

        if (true)
        {
            Debug.Log("This always runs");
        }
    }

    void Update()
    {
        speed = speed + 1;
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
