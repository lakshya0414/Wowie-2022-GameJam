using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int last_index;
    public GameObject menu;
    // public PlayerScript player; 
    void Start()
    {
    
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // public void Continue()
    // {
    //     // player=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    //     // print(player.playerLevel);

    //     // if(player.playerLevel!=0){
    //     //     SceneManager.LoadScene(player.playerLevel);
    //     // }
    //     // else SceneManager.LoadScene(1);

    // }

}

