using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class ControllerButons : MonoBehaviour
{
    public GameObject objectToControl;
    public InputActionReference secondaryButtonAction;
    
    private void Start()
    {
        // Register a callback for the secondary button press on the 
           left controller.

    secondaryButtonAction.action.performed += OnSecondaryButtonPressed;
    
    }

    private void OnSecondaryButtonPressed(InputAction.CallbackContext context)
    {
        // Toggle the visibility or enable/disable the object
        objectToControl.SetActive(!objectToControl.activeSelf);
    }


    private void OnEnable()
    {
        // Enable the action when this script is enabled
        secondaryButtonAction.action.Enable();
    }



    private void OnDisable()
    {
        // Disable the action when this script is disabled or destroyed
        secondaryButtonAction.action.Disable();
    }

   
}
