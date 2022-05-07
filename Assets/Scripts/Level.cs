using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    GameSession gameSession;
    static int whatScene;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadLevels()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        whatScene = 1;
        SceneManager.LoadScene(3);
        FindObjectOfType<GameSession>().ResetGame();
       // Debug.Log("Game Session Reset");
        //Debug.Log(FindObjectOfType<GameSession>().GetScore());
    }

    public void LoadGame1()
    {
        whatScene = 2;
        SceneManager.LoadScene(4);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGame2()
    {
        whatScene = 3;
        SceneManager.LoadScene(5);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadFromOver()
    {
        if(whatScene == 1)
        {
            LoadGame();
        }
        else if(whatScene == 2)
        {
            LoadGame1();
        }
        else if(whatScene == 3)
        {
            LoadGame2();
        }
    }

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Over");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}