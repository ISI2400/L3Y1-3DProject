using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float timer;
    public float timeLimit;
    public TMP_Text timertxt;


    void Start(){
        timer = timeLimit;
    }


    void Update(){
        timertxt.text = timer.ToString("F2");

        if (timer <= 0){
            Debug.Log("out of time");
        }
        else{
            timer -= Time.deltaTime;
        }
    }






}
