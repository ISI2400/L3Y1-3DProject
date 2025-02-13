using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{

    public float secondtime;
    public int minutetime;
    public TMP_Text secondstimer;
    public TMP_Text minutestimer;

    void Update() {

        secondtime += Time.deltaTime;

        if (secondtime >= 60){
            secondtime = secondtime - 60;
            minutetime = minutetime + 1;
        }

        minutestimer.text = minutetime.ToString();
        secondstimer.text = secondtime.ToString("F3");
        
    }



}
