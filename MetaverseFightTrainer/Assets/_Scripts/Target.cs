using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
    private Color startColor;
    private Material material;

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
        material.color = startColor;
    }
}
