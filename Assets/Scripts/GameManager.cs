using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float timer;
    public float timeLimit;
    public TMP_Text timertxt;


    void Start(){
        timer = timeLimit;
    }


    void Update(){

        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        timertxt.text = timer.ToString("F2");
            
        timer += Time.deltaTime;

    }






}
