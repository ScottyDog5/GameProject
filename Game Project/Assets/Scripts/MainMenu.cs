using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MainMenu : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene("GameScene");
    }

    public void howToPlay(){
       SceneManager.LoadScene("HowToPlayScene");
    }

    public void endlessMode (){
        SceneManager.LoadScene("EndlessModeScene");
    }
 
    public void options() {
        
    }
 
    public void exitGame() {
        Application.Quit();
    }
}
