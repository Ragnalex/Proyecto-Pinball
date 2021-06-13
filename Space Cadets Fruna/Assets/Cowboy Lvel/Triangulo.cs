using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangulo : MonoBehaviour
{
    // Start is called before the first frame update
    public float accum = 0.0f;
    public Vector2 p1, p2,p3;
    public bool bb;

    void Start()
    {
        bb = false;
        p1 = new Vector2(1.9f, 1.9f);
        p2 = new Vector2(2.0f, 2.0f);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        bb = true;
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
}