// using System.Reflection.Metadata.Ecma335;
// using System.Diagnostics.Contracts;
// using System.Security;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
using System.Threading;
using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barriers : MonoBehaviour
{
    public Collider2D colliders;
    public PlayerScript player;
    // Start is called before the first frame update
    void Start()
    {
       colliders = GetComponent<Collider2D>(); 
    player=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
       colliders.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeBarrier(int color){
        if(color==4){
            colliders.isTrigger= true;
        }
        else colliders.isTrigger= false;
    }
}
