using System.Collections;
using UnityEngine;

public class Fallinchecker : MonoBehaviour {
    public hole red;
    public hole blue;
    public hole green;

	void OnGUI () {
        string label = " ";
        

        if (red.IsFallIn() )//&& blue.IsFallIn() && green.IsFallIn())
        {
            label = "Fall in Hole!111111111111111111111111111111111111111111111111111111111111111111111111111111!";
        }
        GUI.Label(new Rect(0, 0, 100, 30), label);
	}
	
		
	
}
