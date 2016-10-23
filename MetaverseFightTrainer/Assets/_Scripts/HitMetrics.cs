using UnityEngine;
using System.Collections;

public class HitMetrics : MonoBehaviour {

    public int totalHitCount = 0;
    public int headHitCount = 0;
    public int leftRibsHitCount = 0;
    public int rightRibsHitCount = 0;
    public int breadBasketHitCount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void IncrementHitCount(string targetName)
    { 
        totalHitCount++;
        // Debug.Log("Total Hits: " + totalHitCount);
        if (targetName == "Head")
        {
            headHitCount++;
            // Debug.Log(targetName + ": " + headHitCount);
        }
        else if (targetName == "Bread Basket")
        {
            breadBasketHitCount++;
            // Debug.Log(targetName + ": " + breadBasketHitCount);
        }
        else if (targetName == "Right Ribs")
        {
            rightRibsHitCount++;
            // Debug.Log(targetName + ": " + rightRibsHitCount);
        }
        else if (targetName == "Left Ribs")
        {
            leftRibsHitCount++;
            // Debug.Log(targetName + ": " + leftRibsHitCount);
        }
    }
}
