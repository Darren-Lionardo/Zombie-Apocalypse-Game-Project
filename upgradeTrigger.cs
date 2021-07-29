using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeTrigger : MonoBehaviour
{
    public GameObject upgrademenu;
    public GameObject upgradetxt;
    public int triggeropen = 0;
    public int triggertxtopen = 1;
    public int triggerclose = 0;
    public int triggertxtclose = 0;
    public AudioSource audioSource;
    public AudioClip buttonclip;

    void FixedUpdate(){
            if(triggeropen == 1){
                upgrademenu.GetComponent<RectTransform>().offsetMax += new Vector2(0, 15);
                if(upgrademenu.GetComponent<RectTransform>().offsetMax.y >= -350f){
                    triggeropen = 0;
                }
            }
            if(triggerclose == 1){
                upgrademenu.GetComponent<RectTransform>().offsetMax -= new Vector2(0, 15);
                if(upgrademenu.GetComponent<RectTransform>().offsetMax.y <= -680f){
                    triggerclose = 0;
                }
            }
            if(triggertxtopen == 1){
                upgradetxt.GetComponent<Text>().text = "Open Upgrades";
            }

            if(triggertxtclose == 1){
                upgradetxt.GetComponent<Text>().text = "Close Upgrades";
            }
    }

    public void onClickTriggerUpgrade(){
        audioSource.PlayOneShot(buttonclip, 0.5f);
        if(upgrademenu.GetComponent<RectTransform>().offsetMax.y <= -660f && upgrademenu.GetComponent<RectTransform>().offsetMax.y >= -700f){
            triggeropen = 1;
            triggertxtclose = 1;
            triggertxtopen = 0;
        }
        if(upgrademenu.GetComponent<RectTransform>().offsetMax.y <= -330f && upgrademenu.GetComponent<RectTransform>().offsetMax.y >= -370f){
            triggerclose = 1;
            triggertxtopen = 1;
            triggertxtclose = 0;
        }       
    }
}
