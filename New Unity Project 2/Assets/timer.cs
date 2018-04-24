using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

    private int minute;
    private float seconds;
    private float oldSeconds;
    void Start()
    {
        minute = 0;
        seconds = 0f;
        oldSeconds = 0f;
    }


        void Update() {
    //    string label = " ";
    //    label = "move";

       
        Debug.Log(righthand.righthandflag);


        if ((righthand.righthandflag == true)&&(lefthand.lefthandflag == true)&&(head.headflag == true)) {
            Debug.Log("a");
       //     label = "keep!";
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
            oldSeconds = seconds;
            Debug.Log(seconds);
        }
     //   GUI.Label(new Rect(0, 0, 100, 30), label);

    }
}
