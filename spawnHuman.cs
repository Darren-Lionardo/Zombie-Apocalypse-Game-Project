using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnHuman : MonoBehaviour
{
    public GameObject human;
    public Transform[] humanpoints;
    public static int h;
    public static int t;

    void Start(){
        StartCoroutine(autohuman());
    }
    // Update is called once per frame

    IEnumerator autohuman(){
        while(true){
            h = Random.Range(0, 2);
            t = Random.Range(1, 3);
            Debug.Log("spawnpoint" + h);
            Debug.Log("Seconds" + t);
            Instantiate(human, humanpoints[h].position, Quaternion.identity);
            yield return new WaitForSeconds(t);
        }
    }
}
