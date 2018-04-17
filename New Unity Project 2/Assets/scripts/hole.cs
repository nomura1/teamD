using System.Collections;
using UnityEngine;

public class hole : MonoBehaviour {
    bool fallIn;
    public hole red;
    public string activeTag;
    string label = " ";
    public bool IsFallIn()
    {
        return fallIn;
    } 
    void OnTriggerStay (Collider other)
    {
        if(other.gameObject.tag == activeTag)
        {
     //       fallIn = true;
            label = "!!!!!!!!";
        }
    }
    void OntriggerExit (Collider other)
    {
        if(other.gameObject.tag == activeTag)
        {
       //     fallIn = false;
            label = "????";
        }
    }
	
	
	// Update is called once per frame

}
