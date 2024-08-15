using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameMode
{
    public static bool gameModeEndlessOrNot = false;
    public static bool gameModeEnemies = false;

    public static void endLessOrNotToggle(bool endlessToggled) {
        gameModeEndlessOrNot = endlessToggled;
    }

    public static void gameModeEnemiesToggled(bool enemiesToggled) {
        // only available in endless mode currently
        gameModeEnemies = enemiesToggled;
    }
}