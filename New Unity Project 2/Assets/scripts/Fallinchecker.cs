using System.Collections;
using UnityEngine;

public class Fallinchecker : MonoBehaviour {
    public hole red;
  //  public hole blue;
   // public hole green;

	void OnGUI () {
        string label = " ";
        

        if (red.IsFallIn() )//&& blue.IsFallIn() && green.IsFallIn())
        {
            label = "!!!!!!!!";
        }else {
            label = "????";
        }
        GUI.Label(new Rect(0, 0, 100, 30), label);
	}
	
		
	
}
