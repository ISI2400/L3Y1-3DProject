using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishline : MonoBehaviour
{

    public GameObject carchanger;
    public GameObject finishscreen;



    void OnTriggerEnter(Collider other){
        carchanger.SetActive(false);
        finishscreen.SetActive(true);
    }


}
