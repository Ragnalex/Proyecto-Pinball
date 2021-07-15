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



            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
           
        }
    }
}
