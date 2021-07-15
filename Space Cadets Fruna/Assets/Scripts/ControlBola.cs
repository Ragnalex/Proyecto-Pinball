using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBola : MonoBehaviour
{
    
    private Shake shake;
    public float speed;
    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            shake.CamShake();


            rb.MovePosition(rb.position + new Vector2(1f, 0f) * Time.deltaTime);
           
        }
    }
}
