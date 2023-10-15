using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public GameObject LeftHand;
    public GameObject RightHand;
    public static bool isDeviceVR = false;

    // Start is called before the first frame update
    void Start()
    {
        CheckIfVR();
    }

    public void CheckIfVR()
    {
        var xrSettings = XRGeneralSettings.Instance;

        if (xrSettings == null)
        {
            return;
        }

        var xrManager = xrSettings.Manager;

        if (xrManager == null)
        {
            return;
        }

        var xrLoader = xrManager.activeLoader;

        if (xrLoader == null)
        {
            isDeviceVR = false;
            LeftHand.SetActive(false);
            RightHand.SetActive(false);
        }
        else
        {
            isDeviceVR = true;
            LeftHand.SetActive(true);
            RightHand.SetActive(true);
        }
    }
}
