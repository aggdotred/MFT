using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private Color startColor;
    private Material material;
    // private bool isTargetActive;

    public float originalCountdown;
    public float countdown;


    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
    }
    private void OnTriggerEnter(Collider col)
    {
        material.color = Color.green;
       
    }

    private void OnTriggerExit(Collider col)
    {
        StartCoroutine(TargetCoroutine());
    }


    IEnumerator TargetCoroutine ()
    {
        while (countdown > 0)
        {       
            countdown -= Time.deltaTime;
            yield return null;
        }        
        material.color = startColor;
        countdown = originalCountdown;
    }
}
