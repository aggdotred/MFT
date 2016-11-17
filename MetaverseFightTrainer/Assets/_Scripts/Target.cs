using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private Color startColor;
    private Material material;
    private string targetName;
    private Transform targetTransform;
    private bool isTargetAbleToBeHit;

    public float originalCountdown;
    public float countdown;
    public float impactMovement;
   

    void Start()
    {
        material = GetComponent<Renderer>().material;
        startColor = material.color;
        targetName = this.gameObject.name;
        targetTransform = gameObject.transform;
        isTargetAbleToBeHit = true;
    }


    public void Activate(string targetName)
    {
        Debug.Log(targetName);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (isTargetAbleToBeHit)
        {
            material.color = Color.green;
            HitMetrics hitMetrics = FindObjectOfType<HitMetrics>();
            hitMetrics.IncrementHitCount(targetName);
            targetTransform.position += Vector3.forward * impactMovement;
            isTargetAbleToBeHit = false;
            StartCoroutine(TargetWasHitCoroutine());
        }

    }


    IEnumerator TargetWasHitCoroutine ()
    {
        while (countdown > 0)
        {       
            countdown -= Time.deltaTime;
            yield return null;
        }
        targetTransform.position += Vector3.back * impactMovement;
        material.color = startColor;
        countdown = originalCountdown;
        isTargetAbleToBeHit = true;
    }
}
