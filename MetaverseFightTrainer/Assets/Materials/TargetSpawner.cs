using UnityEngine;
using System.Collections;

public class TargetSpawner : MonoBehaviour {

    public GameObject breadBasketPrefab;
    public GameObject headPrefab;
    public GameObject leftFocusPrefab;
    public GameObject leftRibsPrefab;
    public GameObject rightFocusPrefab;
    public GameObject rightRibsPrefab;
    public GameObject torsoPrefab;


    void Start () {
        GameObject breadBasket = Instantiate(breadBasketPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        breadBasket.transform.parent = transform;
        GameObject head = Instantiate(headPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        head.transform.parent = transform;
        GameObject leftFocus = Instantiate(leftFocusPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        leftFocus.transform.parent = transform;
        GameObject leftRibs = Instantiate(leftRibsPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        leftRibs.transform.parent = transform;
        GameObject rightFocus = Instantiate(rightFocusPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        rightFocus.transform.parent = transform;
        GameObject rightRibs = Instantiate(rightRibsPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        rightRibs.transform.parent = transform;
        GameObject torso = Instantiate(torsoPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        torso.transform.parent = transform;

        foreach ( Transform child in transform)
        {
            GameObject target = Instantiate(child, child.transform.position, Quaternion.identity) as GameObject;
            target.transform.parent = transform; 
        }
    }
	
	
	void Update () {
	
	}
}
