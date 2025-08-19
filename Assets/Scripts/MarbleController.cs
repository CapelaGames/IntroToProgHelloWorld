using UnityEngine;
using UnityEngine.InputSystem;

public class MarbleController : MonoBehaviour
{
    public float speed = 10;
    public float jumpSpeed = 400;
    Vector3 input;
    Rigidbody rb;
    Camera cam;

    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        cam = Camera.main;
        if (cam == null)
        {
            cam = FindFirstObjectByType<Camera>();
        }
    }

    void OnMove(InputValue value)
    {
        Vector2 move = value.Get<Vector2>();
        input = new Vector3(move.x, 0.0f, move.y);
    }

    void OnJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = cam.transform.right * input.x + cam.transform.forward * input.z;
        moveDirection.y = 0f;
        moveDirection.Normalize();

        if (isGrounded)
        {
            rb.AddForce(moveDirection * speed);
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}

