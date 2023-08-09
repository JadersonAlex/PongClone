using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   [Header("Scenes")]
    public string SoccerCPU;
    public string SoccerPVP;

    public string ClassicCPU;
    public string ClassicPVP;
    
    public void Soccer_CPU()
    {
        SceneManager.LoadScene(SoccerCPU);

    }

     public void Soccer_PVP()
    {
        SceneManager.LoadScene(SoccerPVP);

    }
     
      public void Classic_CPU()
      {
        
        SceneManager.LoadScene(ClassicCPU);

      }

      public void Classic_PVP()
      {

        SceneManager.LoadScene(ClassicPVP);

      }




}
