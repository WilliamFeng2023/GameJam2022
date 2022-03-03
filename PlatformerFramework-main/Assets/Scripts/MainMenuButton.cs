/*****************************************
 * Edited by: William Feng
 * Created: 3/2/22
 * Last Edited: 3/2/22
 * Description: Loads the main menu of the game on button click
 * *************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{

    public string sceneName = "MainMenu";
    // Method to be called on On Click()
    public void LoadMainScene()
    {
        // Loads the Main Menu
        SceneManager.LoadScene(sceneName);
    }
}
