using UnityEngine;
using System.Collections;

public class RightRibsPosition : MonoBehaviour {

    void OnDrawGizmos()
    {

        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }
}
