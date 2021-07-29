using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseGame : MonoBehaviour
{
    public GameObject pausepanel;
    public GameObject mainpanel;
    public void onClickPauseGame(){
        Time.timeScale = 0;
        pausepanel.SetActive(true);
        mainpanel.SetActive(false);
    }

    public void onClickResumeGame(){
        Time.timeScale = 1;
        pausepanel.SetActive(false);
        mainpanel.SetActive(true);
    }

    public void onClickBackGame(){
        SceneManager.LoadScene(0);
    }
}
