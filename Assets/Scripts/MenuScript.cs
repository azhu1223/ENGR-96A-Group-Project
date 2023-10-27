using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        Debug.Log("Player Movement Test");
        SceneManager.LoadScene(2);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
