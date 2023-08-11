using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string urlToOpen1; // Insira a URL que você deseja abrir aqui
    public string urlToOpen2;
    public string urlToOpen3;
    public string urlToOpen4;


    public void OpenExternalURL1()
    {
        Application.OpenURL(urlToOpen1);
    }


     public void OpenExternalURL2()
    {
        Application.OpenURL(urlToOpen2);
    }

     public void OpenExternalURL3()
    {
        Application.OpenURL(urlToOpen3);
    }

     public void OpenExternalURL4()
    {
        Application.OpenURL(urlToOpen4);
    }
}