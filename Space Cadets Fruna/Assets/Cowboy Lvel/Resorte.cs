using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resorte : MonoBehaviour
{
    // Start is called before the first frame update
    public float accum = 1.0f;
    public Vector2 p1, p2, p3;
    public bool bb;

    void Start()
    {
        bb = false;
        p1 = new Vector2(0.8f, 1.0f);
        p2 = new Vector2(0.8f, 1.2f);
    }
    
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bb = true;
            accum -= 0.5f;
            p3 = Vector2.Lerp(p1, p2, accum);
            this.transform.localScale = p3;
            
            
        }
        if (Input.GetKeyUp(KeyCode.Space)) { 
            accum += 0.5f;
            p3 = Vector2.Lerp(p1, p2, accum);
            this.transform.localScale = p3;
        }  
        
        
    }   
}
