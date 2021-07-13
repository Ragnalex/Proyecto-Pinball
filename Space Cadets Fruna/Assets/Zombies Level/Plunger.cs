using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plunger : MonoBehaviour
{
    private SpringJoint2D springJoint;
    private Rigidbody2D rb;
    private float force = 0f;          // current force generated
    public float maxForce = 90f;
    public bool isTouched = false;
    public bool isKeyPress = false;
    public GameObject resorte;

    public bool isActive = true;

    private float pressTime = 0f;
    private float startTime = 0f;
    public int powerIndex;



    
    // Start is called before the first frame update
    void Start()
    {
        Transform posRest = resorte.GetComponent<Transform>();
        springJoint = GetComponent<SpringJoint2D>();
        springJoint.distance = 3.52833f;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
        if (isActive)
        {
            if (Input.GetKeyDown("space"))
            {
                isKeyPress = true;
            }

            if (Input.GetKeyUp("space"))
            {
                isKeyPress = false;
            }

            // on keyboard press or touch hotspot
            if (isKeyPress == true && isTouched == false || isKeyPress == false && isTouched == true)
            {
                if (startTime == 0f)
                {
                    startTime = Time.time;
                }
            }

            // on keyboard release 
            if (isKeyPress == false && isTouched == false && startTime != 0f)
            {
                // #1
                force = powerIndex * maxForce;
                
                // reset values & animation
                pressTime = 0f;
                startTime = 0f;
                
               
            }
            
        }
   
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (force != 0)
        {
            // release springJoint and power up
            springJoint.distance = 3.52833f;
            rb.AddForce(Vector3.up * force);
            force = 0;
        }

        // When the plunger is held down
        if (pressTime != 0)
        {
            // retract the springJoint distance and reduce the power
            Transform posRest = resorte.GetComponent<Transform>();
            posRest.localScale = new Vector3(posRest.localScale.x, posRest.localScale.y - 1f, posRest.localScale.z);
            powerIndex = powerIndex + (int)Time.deltaTime;
            springJoint.distance = .8f;
            rb.AddForce(Vector3.down * 400);
        }

    }
}
