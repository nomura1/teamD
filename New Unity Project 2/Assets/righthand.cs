using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class righthand: MonoBehaviour
{

    // Use this for initialization
    void OnTriggerStay (Collider other)
    {

        if(other.gameObject.tag=="activtag") {
            Destroy(other.gameObject);

    }
    }
}