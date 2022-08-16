using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nav : MonoBehaviour
{
   public void Menu()
   {
              SceneManager.LoadScene(0);
   }

   public void restart()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
