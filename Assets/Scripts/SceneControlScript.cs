using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControlScript : MonoBehaviour {

    private static int lastSceneNumber = 0;

    public void nextScene()
    {
        int indexOfCurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexOfCurrentScene + 1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void jumpMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void jumpGameScene()
    {
        SceneManager.LoadScene(1);
    }


    public void jumpLoseScene()
    {
        lastSceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("LoseScreen");
    }

    public void jumpLastScene()
    {
        Blocks.breakableBlockCount = 0;
        SceneManager.LoadScene(lastSceneNumber);
    }

}
