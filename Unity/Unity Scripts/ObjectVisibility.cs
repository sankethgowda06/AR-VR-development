using UnityEngine;

public class ObjectVisibility : MonoBehaviour
{

    public GameObject Object;
    
    // Tracks whether the object has been shown
    bool hasObjectbeenShow = false;
    // This method is called when a GameObject enters the trigger
        collider.
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Object.SetActive(true);
         

        }
    }
    // This method is called when a GameObject exits the trigger
       collider.
    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Object.SetActive(false);

        }
    }
}
