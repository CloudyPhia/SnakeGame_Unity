using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameModeSetter : MonoBehaviour
{
    [SerializeField] GameObject EndlessModeToggle;
    [SerializeField] GameObject EnemiesModeToggle;

    private bool enemyPossibilityActive = false;

    public void Update() {

        if (GameMode.gameModeEndlessOrNot) {
            EndlessModeToggle.GetComponent<Toggle>().isOn = true;
            EnemiesModeToggle.SetActive(true);

            if (GameMode.gameModeEnemies) {
                EnemiesModeToggle.SetActive(true);
                EnemiesModeToggle.GetComponent<Toggle>().isOn = true;
            }

        } 

        if (!GameMode.gameModeEndlessOrNot) {
            gameModeEnemiesToggled(false);
            EnemiesModeToggle.GetComponent<Toggle>().isOn = false;
            EnemiesModeToggle.SetActive(false);
        }

    }
    public void toggleEndless(bool toggle){
        GameMode.endLessOrNotToggle(toggle);
        Debug.Log("endless toggle clicked");
        
        enemyPossibilityActive = !enemyPossibilityActive;
    }

    public void gameModeEnemiesToggled(bool toggle){
        GameMode.gameModeEnemiesToggled(toggle);
        Debug.Log("enemies toggle clicked");
    }
}