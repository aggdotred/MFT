using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HitMetricsDisplay : MonoBehaviour {
    Text text;
    HitMetrics hitMetrics;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        hitMetrics = FindObjectOfType<HitMetrics>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Total Hits: " + hitMetrics.totalHitCount + "\n" +
                    "Head: " + hitMetrics.headHitCount + "\n" +
                    "Left Ribs: " + hitMetrics.leftRibsHitCount + "\n" +
                    "Right Ribs: " + hitMetrics.rightRibsHitCount + "\n" +
                    "Bread Basket: " + hitMetrics.breadBasketHitCount;
	}
}
