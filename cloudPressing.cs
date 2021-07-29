using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloudPressing : MonoBehaviour
{
    public float cloud_value = 0f;
    public int parachute = 0;
    public GameObject zombieparachute;
    public static float incrementPerClick = 1f;
    public GameObject droplets;

    void Start(){
        incrementPerClick = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(parachute == 1){
            Instantiate(zombieparachute, this.transform.position, this.transform.rotation);
            parachute -= 1;
        }
        droplets.GetComponent<Text>().text = "" + cloud_value;
    }
    public void cloudClick(){
        cloud_value = cloud_value + incrementPerClick;
    }
}
