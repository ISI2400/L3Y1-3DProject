using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{

    public GameObject car;

    void OnTriggerEnter(Collider other) {

        Debug.Log("touched");
        car.transform.position = new Vector3(-230,65,360);

    }



}
