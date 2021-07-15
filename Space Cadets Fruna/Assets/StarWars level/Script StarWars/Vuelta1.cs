using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vuelta1 : MonoBehaviour
{
    public SpriteRenderer sp;
    public Sprite sp2;
    public Sprite sp3;
    public bool p;
    public bool s;

    void Start()
    {
        s = false;
        p = true;
        sp = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {   
        if (p)
        {   
            sp.sprite = sp2;
            s = true;
            p = false;
        }
        else{
            sp.sprite = sp3;
            p = true;
            s = false;
        }
    }
}
