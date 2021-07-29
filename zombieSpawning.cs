using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawning : MonoBehaviour
{
    public Transform[] point;
    public GameObject zombie;
    public static float cd = 3f;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        cd = 3f;
        StartCoroutine(autospawn());
    }
        
    IEnumerator autospawn(){
        while(true){
            int i = Random.Range(0, 5);
            Instantiate(zombie, point[i].position, Quaternion.identity);
            yield return new WaitForSeconds(cd);
            }
        }
}
