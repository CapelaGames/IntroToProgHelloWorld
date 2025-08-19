using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 10f;
    public float sensitivity = 100f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    // Late update is like update, but for cameras
    // It runs late, after all the updates run, then all the lateUpdates run
    // End step
    void LateUpdate()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Keep track of mouse movement 
        xRotation += mouseX;
        yRotation += mouseY;

        // Calculatte new position
        Quaternion rotation = Quaternion.Euler(yRotation, xRotation, 0f);
        Vector3 offset = new Vector3(0f, 0f, -distance);

        // Apply changes to the transform of the camera
        transform.position = target.position + rotation * offset;
        transform.LookAt(target);
    }
}
