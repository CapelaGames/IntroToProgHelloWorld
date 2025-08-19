using UnityEngine;

public class MoveWithTranslate : MonoBehaviour
{
    [SerializeField] float speed = 50f;

    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
