using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachuteFalling : MonoBehaviour
{
    public int p;
    public GameObject zombiewalk;
    void Start(){
        p = Random.Range(0, 50);
    }
    void FixedUpdate()
    {
        if(p >= 25){
            transform.Rotate(new Vector3(0, 0, 0.1f));
        }
        if(p < 25){
            transform.Rotate(new Vector3(0, 0, -0.1f));
        }
        if(this.GetComponent<Transform>().position.y <= -3.5f){
            Destroy(gameObject);
            Instantiate(zombiewalk, this.GetComponent<Transform>().position, Quaternion.identity);
        }
    }
}
