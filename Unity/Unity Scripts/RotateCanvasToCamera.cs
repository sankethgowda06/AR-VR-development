using UnityEngine;

public class RotateCanvasToCamera : MonoBehaviour
{
    void Update()
    {
        // Find the main camera
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // Calculate the rotation needed to face the camera
            Vector3 directionToCamera = mainCamera.transform.position – 
transform.position;
            Quaternion rotation =  
            Quaternion.LookRotation(directionToCamera);
            // Remove rotation around X and Z axes
            rotation.x = 0;
            rotation.z = 0; 
            // Rotate the canvas to face the camera
            transform.rotation = rotation;
        }
    }
}
