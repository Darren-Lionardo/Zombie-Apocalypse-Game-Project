using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public void onClickSoundButton(){
        audioSource.PlayOneShot(clip, 0.5f);
    }
}
