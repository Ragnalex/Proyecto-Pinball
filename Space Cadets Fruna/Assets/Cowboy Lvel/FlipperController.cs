using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class FlipperController : MonoBehaviour
{
    

   public bool Flipper;

    void start(){
        
    }


    void Update()
    {
     if ((Flipper && Input.GetKey(KeyCode.RightControl)) || (!Flipper && Input.GetKey(KeyCode.LeftControl))){
         GetComponent<HingeJoint2D>().useMotor = true;
        
         ;

     }
     else
     {GetComponent<HingeJoint2D>().useMotor = false;
        }

    }
}
