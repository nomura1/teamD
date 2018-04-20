using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lefthand : MonoBehaviour
{
    public static bool lefthandflag;

    void Start() {
        lefthandflag = false;
    }

    // Use this for initialization
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "lefthand")
        {
           lefthandflag=true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "lefthand")
        {
            lefthandflag = false;
        }

    }
}
