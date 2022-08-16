using System.Threading;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Dialogs;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
public int PlayerColor=1;
Rigidbody2D body;

float horizontal;
float vertical;
float moveLimiter = 0.7f;

public barriers Barrier;
public float runSpeed = 1.0f;
public Animator animator;

private AudioSource[] audios;
private AudioSource pendrivePick;
private AudioSource hitWall,explosion, levelUp;

// public static Integer playerLevel{
//     set{

//     }
// }
// public int count=1;
void Start ()
{
 Barrier=GameObject.FindGameObjectWithTag("WALL").GetComponent<barriers>();
animator = GetComponent<Animator>();
   body = GetComponent<Rigidbody2D>();
   audios=GetComponents<AudioSource>();
   pendrivePick=audios[1];
   hitWall=audios[0];
   explosion=audios[2];
   levelUp=audios[3];
}

// void changeLevel(int level){
//     if(level==1){
//         SceneManager.LoadScene("Level2");
//     }
// }



void Update()
{
   // Gives a value between -1 and 1
   horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
   vertical = Input.GetAxisRaw("Vertical"); // -1 is down
}

void FixedUpdate()
{
   if (horizontal != 0 && vertical != 0) // Check for diagonal movement
   {
      // limit movement speed diagonally, so you move at 70% speed
      horizontal *= moveLimiter;
      vertical *= moveLimiter;
   } 

   body.velocity = new Vector2(horizontal * runSpeed/2, vertical * runSpeed/2);
}
private void OnCollisionEnter2D(Collision2D other){
    
        if(other.gameObject.CompareTag("RED_PD")){
            pendrivePick.Play();
            animator.SetInteger("PlayerColor",2);
            Destroy(other.gameObject);
            Barrier.ChangeBarrier(animator.GetInteger("PlayerColor"));
        }
        else if(other.gameObject.CompareTag("BLUE_PD")){
            pendrivePick.Play();
            animator.SetInteger("PlayerColor",1);
            Destroy(other.gameObject);
            Barrier.ChangeBarrier(animator.GetInteger("PlayerColor"));
        }
        else if(other.gameObject.CompareTag("GREEN_PD")){
            pendrivePick.Play();
            animator.SetInteger("PlayerColor",3);
            Destroy(other.gameObject);
            Barrier.ChangeBarrier(animator.GetInteger("PlayerColor"));
        }
        else if(other.gameObject.CompareTag("YELLOW_PD")){
            pendrivePick.Play();
            animator.SetInteger("PlayerColor",4);
            Destroy(other.gameObject);
            Barrier.ChangeBarrier(animator.GetInteger("PlayerColor")); 
            popup.instance.show();

        }

        else if(other.gameObject.CompareTag("RED_FINISH")){
            if(animator.GetInteger("PlayerColor")==2){
                // print("Level Complete");
                levelUp.Play();
                body.constraints = RigidbodyConstraints2D.FreezeAll;
                DialogUI.instance.Show();
               
            }
        }
        else if(other.gameObject.CompareTag("YELLOW_FINISH")){
            if(animator.GetInteger("PlayerColor")==4){
                // print("Level Complete");
                levelUp.Play();
                body.constraints = RigidbodyConstraints2D.FreezeAll;
               DialogUI.instance.Show();
            }
        }
        else if(other.gameObject.CompareTag("BLUE_FINISH")){
            // print(animator.GetInteger("PlayerColor"));
            if(animator.GetInteger("PlayerColor")==1){
                // print("Level Complete");
                levelUp.Play();
                print(animator.GetInteger("PlayerColor"));
                body.constraints = RigidbodyConstraints2D.FreezeAll;
               DialogUI.instance.Show();
            }
        }
        else if(other.gameObject.CompareTag("GREEN_FINISH")){
            if(animator.GetInteger("PlayerColor")==3){
                // print("Level Complete");
                levelUp.Play();
                body.constraints = RigidbodyConstraints2D.FreezeAll;
               DialogUI.instance.Show();
            }
        }
        else if(other.gameObject.CompareTag("RED_WALL")){
            hitWall.Play();
            if(animator.GetInteger("PlayerColor")==2){
                explosion.Play();
                Destroy(other.gameObject);
            }
        }
        // else if(other.gameObject.CompareTag("RED_FINISH")){
        //     animator.SetInteger("PlayerColor",4);
        //     Destroy(other.gameObject);
        // }
        // else if(other.gameObject.CompareTag("RED_FINISH")){
        //     animator.SetInteger("PlayerColor",4);
        //     // GameObject.FindGameObjectWithTag("WALL").GetComponent<Rigidbody2D>.isTrigger=true;
        //     Destroy(other.gameObject);
        // }
        // else if(other.gameObject.CompareTag("RED_FINISH")){
        //     animator.SetInteger("PlayerColor",4);
        //     Destroy(other.gameObject);
        // }
    }
    // public void ChangeBarriers(int ){
    //     Barrier.ChangeBarrier(); 
    // }
    // public Animator animator2;
    // public TMP_text popUpText;

    // public void PopUp(string text)[
    //     popUpBox.SetActive(true);
    //     popUpText.text = text;
    //     animator2.SetTrigger("pop");
    // ]
}

