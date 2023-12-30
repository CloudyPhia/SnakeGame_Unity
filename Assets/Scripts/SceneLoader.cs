using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Thanks to https://blog.insane.engineer/post/unity_button_load_scene/
    //  for this script!
    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
