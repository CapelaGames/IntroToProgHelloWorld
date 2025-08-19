using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveWithImpulse : MonoBehaviour
{
    [SerializeField] float speed = 500f;

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
    }
}
