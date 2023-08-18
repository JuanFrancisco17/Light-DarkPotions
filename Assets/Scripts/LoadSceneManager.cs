using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name); //Loads The Scene From The Passed In String Variable
    }

    public void QuitGame()
    {
        Application.Quit(); //Quits Game
    }
}
