using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redPD : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // private void OnCollisionEnter2D(Collision2D other){
    //     if(other.gameObject.CompareTag("Player")){
    //         animator.SetInt("PlayerColor",2);
    //     }
    // }
    // Update is called once per frame
    void Update()
    {
        
    }
}
