using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    public Vector3 offset = new Vector3(0f, 3f, -6f); // Adjust as needed

    void LateUpdate()
    {
        transform.position = ball.position + offset;
        transform.LookAt(ball);
    }
}
    