using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    // Start is called before the first frame update
    public float accum = 0.0f;
    public Vector2 p1, p2,p3;
    public bool bb;
    public float ax, ay;
    public float bx, by;

    void Start()
    {
        bb = false;
        p1 = new Vector2(ax, ay);
        p2 = new Vector2(bx, by);
    }
    
    void FixedUpdate()
    {
        if (bb)
        {
            accum += 0.2f;
            p3 = Vector2.Lerp(p1, p2, accum);
            this.transform.localScale = p3;
            if (p2 == p3) { 
                accum = 0.0f;
                bb = false;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        bb = true;
    }
}