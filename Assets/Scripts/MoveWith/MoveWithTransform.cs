using UnityEngine;

public class MoveWithTransform : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        transform.position += input * speed * Time.deltaTime;
    }
}
