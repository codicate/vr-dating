using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HDMInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);

        string loadedDeviceName = XRSettings.loadedDeviceName;
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No headset plugged in");
        }
        else if (loadedDeviceName == "MockHMD" || loadedDeviceName == "MockHMDDisplay" || loadedDeviceName == "MockHMDDisplayAndTracking")
        {
            Debug.Log("Using MockHMD");
        }
        else
        {
            Debug.Log("Headset is active. Device name: " + loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
