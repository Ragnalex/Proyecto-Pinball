using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala3 : MonoBehaviour
{
    public SpriteRenderer sp;
    public Sprite sp2;
    public Sprite sp3;
    public int cont;
    public bool b;
    public bool activo;

    void Start()
    {
        activo = false;
        b = true;
        cont = 2;
        sp = gameObject.GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        print("Ha ocurrido una colision bumper new 25 - ");

    }
    void OnTriggerEnter2D(Collider2D collider)
    {

        if (b)
        {
            if (cont % 2 == 0)
            {
                print(cont);
                sp.sprite = sp2;
                activo = true;
            }
            else
            {
                print(cont);
                sp.sprite = sp3;
                activo = false;
            }
            cont++;
            b = false;
        }
        print("Ha ocurrido un Trigger bumper new 25 - ");
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        b = true;
    }
}