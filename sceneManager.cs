using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void onClickStartGame(){
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void onClickQuitGame(){
        Application.Quit();
    }
}
