using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Cowboy Level");
    }
    public void Principal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    void Start()
    {
        
    }
    // Update is called once per frame

    void Update()
    {
        
    }
}
