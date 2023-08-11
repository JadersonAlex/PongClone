using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

     public void Return_Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1; // Volta a correr o tempo normalmente

    }


    public void Exit_Game()
    {
        Application.Quit();
    }
}
