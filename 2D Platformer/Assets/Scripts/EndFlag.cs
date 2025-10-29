using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public bool finalLevel;
    public string nextLevelName;


    private void OnTriggerEnter2D(Collider2D collision)// When something enters the trigger collider
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
        }

        else
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}