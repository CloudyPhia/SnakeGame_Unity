using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Thanks to https://blog.insane.engineer/post/unity_button_load_scene/
    //  for teaching me how to make this script!

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
        Debug.Log("LoadScene button works!");
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("Quit the game!");
    }

    public void ReloadCurrentScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("ReloadCurrentScene button works!");
    }


}
