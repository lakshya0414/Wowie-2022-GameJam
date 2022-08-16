using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


namespace EasyUI.Dialogs{

public class popup : MonoBehaviour
{
 
 [SerializeField] GameObject canvas;
    public static popup instance;


     void Awake(){ 
        instance =this;
  
    }
  

    public void show(){
        StartCoroutine(Delay(1));
    }
  
    IEnumerator Delay(float delayTime){
   yield return new WaitForSecondsRealtime(delayTime);
    canvas.SetActive(true);
    yield return new WaitForSecondsRealtime(3);
     canvas.SetActive(false);
}

}
}