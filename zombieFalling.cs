using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieFalling : MonoBehaviour
{
    public int m;
    void Start(){
        m = Random.Range(0, 50);
    }
    void FixedUpdate()
    {
        if(m >= 25){
            transform.Rotate(new Vector3(0, 0, 1f));
        }
        if(m < 25){
            transform.Rotate(new Vector3(0, 0, -1f));
        }
    }
}
