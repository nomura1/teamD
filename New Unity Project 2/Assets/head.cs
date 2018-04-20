using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour

{
    public static bool headflag;

    void Start () {
        headflag = false;

    }

    // Use this for initialization
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "head")
        {
            headflag = true;
           

        }
    }
    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "head") {
            headflag = false;
        }

    }
}