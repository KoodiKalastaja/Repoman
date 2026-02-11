using UnityEngine;

public class Triangle : MonoBehaviour
{
    private bool isRotating = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            isRotating = true;
        }
        if (Input.GetKeyUp("space"))
        {
            isRotating = false;
        }
        if (isRotating)
            Go();
    }
    void Go()
    {
        transform.Rotate(0f, 1f, 0f, Space.Self); 
        Debug.Log("Spinning");
    }
}
