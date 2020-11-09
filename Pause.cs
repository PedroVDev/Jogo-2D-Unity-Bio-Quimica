using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    int aminoacido = 0;
    public Text txtAminoacido;

    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public static bool IsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        IsPaused = true;
        Panel1.SetActive(true);
    }
    public void pauseGame2()
    {
        Time.timeScale = 0f;
        IsPaused = true;
        Panel2.SetActive(true);
    }
    public void pauseGame3()
    {
        Time.timeScale = 0f;
        IsPaused = true;
        Panel3.SetActive(true);
    }
    public void pauseGame4()
    {
        Time.timeScale = 0f;
        IsPaused = true;
        Panel4.SetActive(true);
    }
    public void pauseGame5()
    {
        Time.timeScale = 0f;
        IsPaused = true;
        Panel5.SetActive(true);
    }

    public void Resume ()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        Panel1.SetActive(false); 
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);

    }
    public void Resume2()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        Panel2.SetActive(false);

    }
    public void Resume3()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        Panel3.SetActive(false);

    }
    public void Resume4()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        Panel4.SetActive(false);

    }
    public void Resume5()
    {
        Time.timeScale = 1f;
        IsPaused = false;
        Panel5.SetActive(false);

    }
    public void Count()
    {
        aminoacido++;
        Time.timeScale = 1f;
        IsPaused = false;
        Panel1.SetActive(false);

    }
    public void Count2()
    {
        aminoacido++;
        Time.timeScale = 1f;
        IsPaused = false;
        Panel2.SetActive(false);

    }
    public void Count3()
    {
        aminoacido++;
        Time.timeScale = 1f;
        IsPaused = false;
        Panel3.SetActive(false);

    }
    public void Count4()
    {
        aminoacido++;
        Time.timeScale = 1f;
        IsPaused = false;
        Panel4.SetActive(false);

    }
    public void Count5()
    {
        
        Time.timeScale = 1f;
        IsPaused = false;
        Panel5.SetActive(false);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "panel1")
        {
            pauseGame();
            Destroy(collision.gameObject);

        }
        else if (collision.transform.tag == "panel2")
        {
            pauseGame2();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "panel3")
        {
            pauseGame3();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "panel4")
        {
            pauseGame4();
            Destroy(collision.gameObject);
        }
        else if (collision.transform.tag == "panel5")
        {
            pauseGame5();
            Destroy(collision.gameObject);
        }
        else
        {
            Resume();
        }



    }

    // Update is called once per frame
    void Update()
    {
        txtAminoacido.text = "Aminoacido: " + aminoacido; 

        if (aminoacido == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
