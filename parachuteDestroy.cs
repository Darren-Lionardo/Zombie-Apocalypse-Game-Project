using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parachuteDestroy : MonoBehaviour
{
    void FixedUpdate(){
        if(this.transform.position.y <= -10){
            Destroy(gameObject);
            Debug.Log("destroy");
        }
    }
}
