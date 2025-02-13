using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelselectscript : MonoBehaviour
{

    [Header("UI")]
    public GameObject startscreen;
    public GameObject levelselector;


    public void LevelSelect(){
        startscreen.SetActive(false);
        levelselector.SetActive(true);
    }

    public void Cave(){
        SceneManager.LoadScene("cavemap");
    }


}
