using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class KillBall : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;
    public int VidaMaxima = 3;
    public int vidaActual;
    public TextMeshProUGUI vidas;
    public GameObject PanelGameOver;
    public Rigidbody2D rb;
    private Shake shake;
    private int contadorTilt = 0;
    private GameObject ball;
    public float deltaMovement = 1f;
    void Start()


    {
        PanelGameOver.SetActive(false);
        vidaActual = VidaMaxima;
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        ball = GameObject.FindGameObjectWithTag("Ball");

    }
    void Update()
    {
        vidas.text = "" + vidaActual;
        if (vidaActual < 1)
        {
            gameOver();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            shake.CamShake();
            contadorTilt++;
            if (contadorTilt % 3 == 0)
            {
                vidaActual = vidaActual - 1;
                ball.transform.position = spawnpoint.position;

            }


            ball.transform.Translate(Vector2.right * deltaMovement * Time.deltaTime);

        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Ball"))
        {
            if (vidaActual > 1)
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
        Time.timeScale = 0f;
        PanelGameOver.SetActive(true);

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

