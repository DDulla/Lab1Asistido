using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public void PLAY()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void BACK()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QUIT()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
