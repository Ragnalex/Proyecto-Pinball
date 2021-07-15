using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    // Start is called before the first frame update
    public float accum = 0.0f;
    public Vector2 p1, p2, p3;
    public bool b;
    public float ax, ay;
    public float bx, by;
    void Start()
    {
        b = false;
        p1 = new Vector2(ax,ay);
        p2 = new Vector2(bx,by);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        b = true;
    }
    void FixedUpdate()
    {
        if (b)
        {
            accum += 0.2f;
            p3 = Vector2.Lerp(p1, p2, accum);
            this.transform.localScale = Vector2.Lerp(p1, p2, accum); ;
            if (p3 == p2) {
                accum = 0.00f;
                b = false; 
            }            
        }
    }
}
