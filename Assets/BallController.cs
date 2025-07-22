using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 dragStart;
    private Vector3 dragEnd;
    private bool isDragging = false;
    public float forceMultiplier = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragStart = Input.mousePosition;
            isDragging = true;
        }

        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            dragEnd = Input.mousePosition;
            Vector3 dragVector = dragStart - dragEnd;
            Vector3 forceDir = new Vector3(dragVector.x, 0, dragVector.y);
            rb.AddForce(forceDir * forceMultiplier, ForceMode.Impulse);
            isDragging = false;
        }
    }
}
