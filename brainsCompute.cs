using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brainsCompute : MonoBehaviour
{
    public GameObject brainstext;
    public static float brains = 0f;
    public static float increment = 1f;
    // Update is called once per frame

    void Start(){
        brains = 0f;
        increment = 1f;
    }

    void Update()
    {
        brainstext.GetComponent<Text>().text = "Brains: " + brains;
    }
}
