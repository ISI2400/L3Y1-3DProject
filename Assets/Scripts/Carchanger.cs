using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carchanger : MonoBehaviour
{

    public Vector3 spawnpoint;

    public GameObject currentcar;
    public GameObject spongecar;
    public GameObject racecar;



    public void Spongecar(){
        Destroy(currentcar);
        currentcar = Instantiate(spongecar, spawnpoint, Quaternion.identity);
    }

    public void Racecar(){
        Destroy(currentcar);
        currentcar = Instantiate(racecar, spawnpoint, Quaternion.identity);        
    }



}
