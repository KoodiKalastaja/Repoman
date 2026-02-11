using UnityEngine;

public class Triangle : MonoBehaviour
{
    public float rotateSpeed = 0.7f;

    void Update()
    {
        float yRotation = Input.GetAxis("Vertical") * rotateSpeed;
        float xRotation = Input.GetAxis("Horizontal") * rotateSpeed;

        yRotation *= Time.deltaTime;
        xRotation *= Time.deltaTime;

        transform.Rotate(yRotation * rotateSpeed, xRotation * rotateSpeed, 0f, Space.Self);
    }
}
