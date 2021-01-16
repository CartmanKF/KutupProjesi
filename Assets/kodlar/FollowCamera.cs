using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
   [SerializeField] Transform karakter;


    void Start(){
    
    
    
    }

    
    
        
    

    
   void Update(){
  
      transform.position = new Vector3(karakter.position.x +6, karakter.position.y + 1.2f, -10);
      }
     }
        
     
      
     
     

     

