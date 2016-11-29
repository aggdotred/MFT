using UnityEngine;
using System.Collections;

public class TorsoPosition : MonoBehaviour {

    void OnDrawGizmos()
    {

        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }
}
