using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefthand : MonoBehaviour
{


    // Use this for initialization
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "lefthand")
        {
            Destroy(other.gameObject);

        }
    }
}
