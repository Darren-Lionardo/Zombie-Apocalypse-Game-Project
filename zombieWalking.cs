using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieWalking : MonoBehaviour
{
    public int u;
    public int triggerrightz, triggerleftz;
    // Start is called before the first frame update
    void Start()
    {
        u = Random.Range(0,2);
        if(u == 0){
            triggerrightz = 1;
        }
        if(u == 1){
            triggerleftz = 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(triggerrightz == 1){
            transform.Translate(Vector3.right * Time.fixedDeltaTime * 1);
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        if(triggerleftz == 1){
            transform.Translate(Vector3.left * Time.fixedDeltaTime * 1);
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(this.transform.position.x <= -10 || this.transform.position.x >= 10){
            Destroy(gameObject);
        }
    }
}
