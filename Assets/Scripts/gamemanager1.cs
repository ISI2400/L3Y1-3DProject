using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager1 : MonoBehaviour
{

    public GameObject menu;
    public GameObject carselector;
    public int menuactive = 0;
    
    public void Resume(){
        menu.SetActive(false);
        menuactive = 0;
    }

    public void Carselect(){
        menu.SetActive(false);
        menuactive = 1;
        carselector.SetActive(true);
    }

    public void Back(){
        carselector.SetActive(false);
        menu.SetActive(true);
    }

    public void Mainmenu(){
        SceneManager.LoadScene("main menu");
    }


    void Update(){

        if (Input.GetKeyDown(KeyCode.Escape)){
            
            if (menuactive == 0){
                menu.SetActive(true);
                menuactive = 1;

            }

        }


    }




}
