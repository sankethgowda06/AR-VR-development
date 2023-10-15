using UnityEngine;
using UnityEngine.InputSystem;

public class AvatarHeightHelper : MonoBehaviour
{
    [SerializeField] private GameObject Camera;
    [SerializeField] private GameObject CameraOffset;
    [SerializeField] private GameObject XROrigin;
    [SerializeField] private InputActionReference calibrateTrigger;
    

    public void Calibrate()
    {
        CameraOffset.transform.localPosition = new Vector3(0, (1.625f - Camera.transform.position.y) + CameraOffset.transform.localPosition.y + XROrigin.transform.localPosition.y, 0);
        gameObject.transform.Find("CalibratePanel").gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        calibrateTrigger.action.performed += Action_performed;
    }

    private void Action_performed(InputAction.CallbackContext obj)
    {
        
            gameObject.transform.Find("CalibratePanel").gameObject.SetActive(true);
        
    }
    

    private void OnDisable()
    {
        calibrateTrigger.action.performed -= Action_performed;
    }
}

