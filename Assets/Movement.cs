using UnityEngine;

public class Movement : MonoBehaviour
{

    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around Z-axis (2D rotation happens on Z)
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}

