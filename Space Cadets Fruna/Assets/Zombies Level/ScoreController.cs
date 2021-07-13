using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{


    public int score;
    public Text TXTscore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TXTscore.text = "" + score;
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Bumper10"){
            score = score + 10;
        }
        else if (collision.gameObject.tag == "Bumper25"){
            score = score + 25;
        }
        else if (collision.gameObject.tag == "Bumper50"){
            score = score + 50;
        }
        else if (collision.gameObject.tag == "Bumper100"){
            score = score + 100;
        }
        else if (collision.gameObject.tag == "MultiX2"){
            score = score*2;
        }
        else if (collision.gameObject.tag == "MultiX3"){
            score = score*3;
        }
        else if (collision.gameObject.tag == "MultiX5"){
            score = score*5;
        }
    }
}
