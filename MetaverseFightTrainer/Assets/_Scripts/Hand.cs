using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class Hand : MonoBehaviour {
    //private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;   
    

    //private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    private void OnTriggerEnter(Collider col)
    {
        device.TriggerHapticPulse();
    }

    private void OnTriggerExit(Collider col)
    {
       
    }
}
