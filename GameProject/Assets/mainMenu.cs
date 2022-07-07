using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Debug.Log ("QUIT");
        Application.Quit();
    }
}
