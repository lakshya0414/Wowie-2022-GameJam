using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIscript : MonoBehaviour
{
    public static UIscript instance;
    // Start is called before the first frame update
    void Start()
    {
       DontDestroyOnLoad(instance); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
