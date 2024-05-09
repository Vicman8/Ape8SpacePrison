using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
}
