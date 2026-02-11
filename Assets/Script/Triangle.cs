using UnityEngine;

public class Triangle : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Go();
    }

    void Go()
    {
        if (Input.GetKeyDown("space")) 
        {
            transform.Rotate(0f, 1f, 0f, Space.Self); 
            Debug.Log("Spinning");
        }
    }
}
