using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    float power;
    float minPower = 0f;
    public float maxPower = 2000;
    public Slider PowerSlider;
    List<Rigidbody2D> ballList;
    bool ballReady;
    public GameObject plunger;
    private float count;
    private Vector3 position;
    private bool move;

    void Start()
    {
        PowerSlider.minValue = 0f;
        PowerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody2D>();
        count = 0.5f;
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        PowerSlider.value = power;
        if (ballReady){
            PowerSlider.gameObject.SetActive(true);
        }
        else{
            PowerSlider.gameObject.SetActive(false);
        }
        if (ballList.Count > 0){
            ballReady = true;
            if (Input.GetKey(KeyCode.Space)){
                if (power <= 2000){
                    float aux = 800*Time.deltaTime;
                    power = power + aux;
                    count = count + 0.5f;
                    plunger.transform.Translate(Vector3.down * Time.deltaTime);
                }

            }
            if (Input.GetKeyUp(KeyCode.Space)){
                foreach(Rigidbody2D r in ballList){
                    r.AddForce(power*Vector3.up);
                }
                move = true;
            }
        }
        else{
            ballReady = false;
            power = 0f;
        }
        if (move == true){
            if (plunger.transform.position.y <= position.y){
                plunger.transform.Translate(Vector3.up*Time.deltaTime);
            }
            else{
               move = false;
            }
                    
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Ball")){
            ballList.Add(other.gameObject.GetComponent<Rigidbody2D>());
            position = plunger.transform.position;
        }
    }


    private void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.CompareTag("Ball")){
            ballList.Remove(other.gameObject.GetComponent<Rigidbody2D>());
            power = 0f;
        }
    }
}
