using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lost : MonoBehaviour
{
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "ZonaLost"){
            SceneManager.LoadScene("MenuPrincipal");
        }
    }
}
