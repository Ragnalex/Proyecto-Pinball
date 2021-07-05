using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KillBall : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    public int VidaMaxima = 3;
    public int vidaActual;
    public Text vidas;
    public GameObject PanelGameOver;

    void Start()
    {
        PanelGameOver.SetActive(false);
        vidaActual = VidaMaxima;
    }
    void Update()
    {
        vidas.text = "" + vidaActual;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Ball"))
        {
            if(vidaActual > 1)
            {
                col.transform.position = spawnpoint.position;
                vidaActual = vidaActual - 1;
            }
            else
            {
                gameOver();
            }
            
        }

    }
    public void gameOver()
    {
        PanelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Cargarmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

