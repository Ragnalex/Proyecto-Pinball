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
    public void Level2()
    {
        SceneManager.LoadScene("TerrorLevel");
    }
    public void Level3()
    {
        SceneManager.LoadScene("StarWars level");
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
