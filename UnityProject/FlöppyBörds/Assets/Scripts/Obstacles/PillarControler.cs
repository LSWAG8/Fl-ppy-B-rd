using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarControler : MonoBehaviour
{

    public float destroytime = 4f;
   

   

    
    void Start()
    {
       
        Destroy(gameObject, destroytime);
    }

    
    void Update()
    {
      
    }

   
}
