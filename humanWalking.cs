using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanWalking : MonoBehaviour
{
    int triggerright;
    int triggerleft;
    void Start(){
        if(spawnHuman.h == 0){
            triggerright = 1;
        }
        if(spawnHuman.h == 1){
            triggerleft = 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(triggerright == 1){
            transform.Translate(Vector3.right * Time.fixedDeltaTime * 2);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        if(triggerleft == 1){
            transform.Translate(Vector3.left * Time.fixedDeltaTime * 2);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(this.transform.position.x <= -20 || this.transform.position.x >= 20){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hit){
        if(hit.tag == "zombie"){
            Destroy(gameObject);
        }
    }
}
