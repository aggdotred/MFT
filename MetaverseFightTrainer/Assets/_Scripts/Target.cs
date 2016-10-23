using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private Color startColor;
    private Material material;
    private string targetName;
    // private bool isTargetActive;

    public float originalCountdown;
    public float countdown;
   

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
        targetName = this.gameObject.name;
    }
    private void OnTriggerEnter(Collider col)
    {
        material.color = Color.green;
        HitMetrics hitMetrics = FindObjectOfType<HitMetrics>();
        hitMetrics.IncrementHitCount(targetName);
                
        // StartCoroutine(TargetCoroutine());

    }

    private void OnTriggerExit(Collider col)
    {

        material.color = startColor;
    }


    //IEnumerator TargetCoroutine ()
    //{
    //    while (countdown > 0)
    //    {       
    //        countdown -= Time.deltaTime;
    //        yield return null;
    //    }        
    //    material.color = startColor;
    //    countdown = originalCountdown;
    //}
}
