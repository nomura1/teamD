using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class righthand: MonoBehaviour
{
    public static bool righthandflag;

    void Start() {
        righthandflag = false;
    }
    // Use this for initialization
    void OnTriggerStay (Collider other)
    {

        if(other.gameObject.tag=="righthand") {
            righthandflag = true;


    }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "righthand")
        {
            righthandflag = false;
        }

    }
}