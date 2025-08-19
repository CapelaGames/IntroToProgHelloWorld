using UnityEngine;

// Optional
[RequireComponent(typeof(CharacterController))]
public class MoveWithChartacterController : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] float speed = 10f;

    void Start()
    {
        // GetComponent looks at the gameobject, and trys to find the component
        // In this case, its <CharacterController>, always the one in the <>
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float speedWithDelta = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(Vector3.forward * speedWithDelta);
        }

        if (Input.GetKey(KeyCode.S))
        {
            controller.Move(-Vector3.forward * speedWithDelta); //Vector3.back
        }
    }
} 
