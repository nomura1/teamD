using System.Collections;
using UnityEngine;

public class hole : MonoBehaviour {
    bool fallIn;

    public string activeTag;
    public bool IsFallIn()
    {
        return fallIn;
    } 
    void OnTriggerStay (Collider other)
    {
        if(other.gameObject.tag == activeTag)
        {
            fallIn = true;
        }
    }
    void OntriggerExit (Collider other)
    {
        if(other.gameObject.tag == activeTag)
        {
            fallIn = false;
        }
    }
	
	
	// Update is called once per frame

}
