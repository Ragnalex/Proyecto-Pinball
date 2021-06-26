using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    float power;
    float minPower = 0f;
    public float maxPower = 100f;
    public Slider PowerSlider;
    List<Rigidbody2D> ballList;
    bool ballReady;

    void Start()
    {
        PowerSlider.minValue = 0f;
        PowerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballReady){
            PowerSlider.gameObject.SetActive(true);
        }
        else{
            PowerSlider.gameObject.SetActive(false);
        }
        PowerSlider.value = power;
        if (ballList.Count > 0){
            ballReady = true;
            if (Input.GetKeyDown(KeyCode.Space)){
                if (power <= maxPower){
                    power += 50*Time.deltaTime;
                }
            }
            if (Input.GetKeyUp(KeyCode.Space)){
                foreach(Rigidbody2D r in ballList){
                    r.AddForce(power*Vector3.forward);
                }
            }
        }
        else{
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Ball")){
            ballList.Add(other.gameObject.GetComponent<Rigidbody2D>());
        }
    }

    private void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("Ball")){
            ballList.Remove(other.gameObject.GetComponent<Rigidbody2D>());
            power = 0f;
        }
    }
}
