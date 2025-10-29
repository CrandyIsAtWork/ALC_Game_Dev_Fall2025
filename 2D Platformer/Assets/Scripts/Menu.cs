using System.Collections;// Collections namespace
using System.Collections.Generic;// Collections namespace for lists
using UnityEngine;// UnityEngine namespace for MonoBehaviour
using UnityEngine.SceneManagement;// Import SceneManagement for scene loading

public class Menu : MonoBehaviour// Menu class to handle menu interactions
{
    public void OnPlayButton()// Method to handle Play button click
    {
        SceneManager.LoadScene("1");// Load the main game scene
    }

    public void OnQuitButton()// Method to handle Quit button click
    {
        Application.Quit();// Quit the application
    }
}
