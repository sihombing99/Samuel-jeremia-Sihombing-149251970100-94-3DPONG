using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void mainMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void caramian(){
        SceneManager.LoadScene("HowToPlay");
    }
    public void game(){
        SceneManager.LoadScene("Play");
    }
    public void exitbutton()
    {
        Application.Quit();
        Debug.Log("game dimatikan");
    }
    
}
