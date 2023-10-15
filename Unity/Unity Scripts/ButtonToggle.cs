using UnityEngine;
using UnityEngine.UI;

public class ButtonToggle : MonoBehaviour
{
    public GameObject[] objects; // Array of objects to toggle
    public Button[] buttons; // Array of buttons for toggling objects

    private GameObject currentActiveObject;

    void Start()
    {
        // Ensure the arrays are of the same length
        if (objects.Length != buttons.Length)
        {
            Debug.LogError("The number of objects and buttons should be the same.");
            return;
        }

        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Capture the current index

            // Add a click listener to toggle the associated object
            buttons[i].onClick.AddListener(() => ToggleObject(objects[index]));
        }
    }

    void ToggleObject(GameObject objToToggle)
    {
        if (currentActiveObject != objToToggle)
        {
            // Disable the currently active object, if any
            if (currentActiveObject != null)
                currentActiveObject.SetActive(false);

            // Enable the clicked object
            objToToggle.SetActive(true);

            // Update the currently active object
            currentActiveObject = objToToggle;
        }
        else
        {
            // Toggle off the clicked object if it's the currently active one
            objToToggle.SetActive(false);

            // Clear the currently active object
            currentActiveObject = null;
        }
    }
}
