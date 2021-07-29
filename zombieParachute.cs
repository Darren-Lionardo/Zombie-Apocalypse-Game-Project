using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieParachute : MonoBehaviour
{
    public static float needed_value = 5f;

    void OnTriggerEnter2D (Collider2D hitinfo){
        if(hitinfo.gameObject.tag == "Bcloud" && hitinfo.GetComponent<cloudPressing>().cloud_value >= needed_value){
            Destroy(gameObject, 0.05f);
            hitinfo.GetComponent<cloudPressing>().parachute += 1;
            hitinfo.GetComponent<cloudPressing>().cloud_value = hitinfo.GetComponent<cloudPressing>().cloud_value - needed_value;
            brainsCompute.brains += brainsCompute.increment;
            Debug.Log(hitinfo.name);
        }
    }

    void FixedUpdate(){
        if(this.transform.position.y <= -10){
            Destroy(gameObject);
            Debug.Log("destroy");
        }
    }
}
