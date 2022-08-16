using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace EasyUI.Dialogs{

public class DialogUI : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Button tryagain;
    [SerializeField] Button nextlevel;
    public int counter = 1;
    // public PlayerScript player;
    public static DialogUI instance;

    void Start()
    {
    // player=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
    }
    void changeLevel(int level){
        // player.playerLevel++;
        // print(player.playerLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    //     print(level);
    // if(level==1){
    //     SceneManager.LoadScene("Level2");
    // }
    // else if(level==2){
    //     SceneManager.LoadScene("Level3");
    // //     void Awake(){
    // //     instance =this;
    // // }
    // }
    // else if(level==3){
    //     SceneManager.LoadScene("Level4");
    // //     void Awake(){
    // //     instance =this;
    // // }
    // }
}

    // void Start(){
    //     // DontDestroyOnLoad(instance);
    // }

    void Awake(){
        print("hi");
        instance =this;
        //  DontDestroyOnLoad(instance);
    }
    public void Tryagain(){
        print("Trying again");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Nextlevel(){
        print("hi");
        print("Moving to next level");
        changeLevel(counter);
        counter++;
    }

    public void Show(){
        StartCoroutine(DelayAction(1));
    }
    public void Hide(){
        canvas.SetActive(false);
    }
    IEnumerator DelayAction(float delayTime){
   yield return new WaitForSecondsRealtime(delayTime);
    canvas.SetActive(true);
}

}
}