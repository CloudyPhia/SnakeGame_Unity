using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject gameMainMenuButton;

    public void ToggleDeathPanel() {
        deathPanel.SetActive(!deathPanel.activeSelf);
        gameMainMenuButton.SetActive(!gameMainMenuButton.activeSelf);

    }
}
