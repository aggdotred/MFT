using UnityEngine;
using System.Collections;

public class Uke : MonoBehaviour {

    public float ukeMoveSpeed = 1.0f;

    public float maxXPos = .5f;
    public float minXPos = -.5f;

    private bool movingLeft = false;
    private bool movingRight = true;
	
	void Start () {
        
	}
	
	void Update () {

        if (movingRight)
        {
            transform.position += new Vector3(ukeMoveSpeed * Time.deltaTime, 0, 0);
        } else
        {
            transform.position -= new Vector3(ukeMoveSpeed * Time.deltaTime, 0, 0);
        }

        
        if (transform.position.x <= minXPos)
        {
            movingRight = true;
        } else if (transform.position.x >= maxXPos)
        {
            movingRight = false;
        }
    }

   
}
