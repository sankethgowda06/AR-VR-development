using UnityEngine;

public class RotateObject : MonoBehaviour
{   
    // Adjust the speed of rotation in the Inspector
    public float rotationSpeed_Y = 30.0f; 

    void Update()
    {
        // Rotate the object around its Y-axis -> Vecor3.up
        // Rotate the object around its X-axis -> Vecotr3.right
        // Rotate the object around its Z-axis -> Vecotr3.forward

        transform.Rotate(Vector3.up * rotationSpeed_Y * Time.deltaTime);
       
    }
}
