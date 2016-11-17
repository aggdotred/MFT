using UnityEngine;
using System.Collections;

public class Uke : MonoBehaviour {

    public float ukeMoveSpeed;

    public float maxXPos = .5f;
    public float minXPos = -.5f;

    private Transform ukeTransform;
    private float ukeMoveRange;

    private Uke uke;
	
	void Start () {
        ukeTransform = gameObject.transform;
        ukeMoveRange = maxXPos - minXPos;
	}
	
	void Update () {

        
        

        //if(ukeTransform.position.x < maxXPos)
        //{
        //    ukeTransform.position += Vector3.left * .1f;
        //} else if(ukeTransform.position.x == minXPos)
        //{
        //    ukeTransform.position += Vector3.right * .1f;
        //}
        
    }

    void moveUkeLeft()
    {

    }

    void moveUkeRight()
    {

    }
}
