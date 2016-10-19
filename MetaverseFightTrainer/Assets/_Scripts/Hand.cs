﻿using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;   
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	// Update is called once per frame
	void Update () {
        if (controller == null)
        {
            Debug.Log("Controller not init");
            return;
        }
        

        if (controller.GetPressDown(gripButton))
        {
            Debug.Log("Grip button pressed down");
        }
        
        if (controller.GetPressUp(gripButton))
        {
            Debug.Log("Grip button released");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Trigger entered");
    }

    private void OnTriggerExit(Collider col)
    {
        Debug.Log("Trigger exit");
    }
}
