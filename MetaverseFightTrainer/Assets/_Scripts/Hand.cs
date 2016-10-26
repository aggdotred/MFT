using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class Hand : MonoBehaviour {
    
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    //[Space(5)]
    //[Header("Haptics")]
    //[Space(5)]
    //[Range(0, 5)]
    //public int pulseCount;
    //[Range(0.0f, 5.0f)]
    //public float pulseLength;
    //[Range(0.0f, 5.0f)]
    //public float pauseLength;
    

	void Awake () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
	
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
    }

    private void OnTriggerEnter(Collider col)
    {
        device.TriggerHapticPulse();
        //StartCoroutine(HapticPatternPulse(pulseCount, pulseLength, pauseLength));
    }

    private void OnTriggerExit(Collider col)
    {
       
    }

    //IEnumerator HapticPatternPulse(int pulseCount, float pulseLength, float pauseLength)
    //{
    //    for (int i = 0; i < pulseCount; i++)
    //    {
    //        yield return StartCoroutine(HapticSinglePulse(pulseLength));
    //        yield return new WaitForSeconds(pauseLength);

    //    }
    //}

    //IEnumerator HapticSinglePulse(float length)
    //{
    //    for (float i = 0; i < length; i += Time.deltaTime)
    //    {
    //        device.TriggerHapticPulse();
    //        yield return null;
    //    }
    //}
}
