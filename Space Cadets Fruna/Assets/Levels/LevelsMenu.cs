using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Level1()
    {
        SceneManager.LoadScene(2);
    }
    public void Level2()
    {
        SceneManager.LoadScene(3);
    }
    public void Level3()
    {
        SceneManager.LoadScene(4);
    }
    public void Level4()
    {
        SceneManager.LoadScene(5);
    }
    public void Level5()
    {
        SceneManager.LoadScene(6);
    }
    public void Level6()
    {
        SceneManager.LoadScene(7);
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
