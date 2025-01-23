using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollider : MonoBehaviour
{

    public Vector3 lastPos;



    void Start()
    {
        lastPos = transform.position;
    }



    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("KillTrigger")){
            Debug.Log("collided");
            transform.position = lastPos;
        }

        if (other.gameObject.CompareTag("Checkpoint")){
            lastPos = transform.position;
        }
    }

}
