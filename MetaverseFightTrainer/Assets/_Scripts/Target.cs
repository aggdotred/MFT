using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private Color startColor;
    private Material material;
    private string targetName;
    private Transform targetTransform;
    private bool isTargetActive;

    public float originalCountdown;
    public float countdown;
    public float impactMovement;
   

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
        targetName = this.gameObject.name;
        targetTransform = gameObject.transform;
        impactMovement = 0.05f;
        isTargetActive = true;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (isTargetActive)
        {
            material.color = Color.green;
            HitMetrics hitMetrics = FindObjectOfType<HitMetrics>();
            hitMetrics.IncrementHitCount(targetName);
            targetTransform.position += Vector3.forward * impactMovement;
            isTargetActive = false;
            StartCoroutine(TargetCoroutine());
        }

    }

    

    IEnumerator TargetCoroutine ()
    {
        while (countdown > 0)
        {       
            countdown -= Time.deltaTime;
            yield return null;
        }
        targetTransform.position += Vector3.back * impactMovement;
        material.color = startColor;
        countdown = originalCountdown;
        isTargetActive = true;
    }
}
