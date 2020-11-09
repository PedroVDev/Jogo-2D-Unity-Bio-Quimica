using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour

{   //Movimento do Jogador e Colisão
    Vector3 posicao;
    public float velocidade = 50f;
    public Animator anim;
    float HorizontalMove = 0f;

    //Sair do jogo
    public KeyCode sair;
    public GameObject sa;

    //Pulo
    public KeyCode pulo;
    public float forcaPulo = 30f;
    Rigidbody2D rigid;
    bool permicao;

    //Usando LayerMask Para definir onde é o chão
    public bool Isgrounded;
    public Transform feetPosition;
    public float sizeRadius;
    public LayerMask whatIsGround;

    //Paineis Aminoacido
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;

    public GameObject textoEr;
    public GameObject textoEr2;
    public GameObject textoEr3;
    public GameObject textoEr4;
    public GameObject textoEr5;

    public static bool IsPaused = false;

    //ph e inimigo
    public GameObject textoPh;
    public GameObject phDes;
    int ph = 3;

    void Start()
    {
        posicao = transform.position;
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(sair))
        {
            sa.SetActive(true);
        }

        //Reconhecer o chão
        Isgrounded = Physics2D.OverlapCircle(feetPosition.position, sizeRadius, whatIsGround);

        //Movimentação
        transform.Translate(new Vector3(HorizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * velocidade, 0, 0));

        //animação
        anim.SetFloat("velocidade", Mathf.Abs(HorizontalMove));

        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }



    }

    public void OnCollisionEnter2D(Collision2D collision)
    //Colisão com outros objetos
    {
        Isgrounded = true;


        if (collision.transform.tag == "desPh")
        {
            ph--;
            textoPh.SetActive(false);
            phDes.SetActive(true);
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "regPh")
        {
            ph++;
            textoPh.SetActive(true);
            phDes.SetActive(false);
            Destroy(collision.gameObject);
        }

        if (ph == 0)
        {

            SceneManager.LoadScene(3);
        }
        if (collision.transform.tag == "aminoacido")
        {

            permicao = true;

        }

        if (collision.transform.tag == "gameover")
        {

            transform.position = posicao;
        }

    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (permicao == false)
        {
            permicao = false;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        Isgrounded = false;
    }

    public void VOltar()
    {
        sa.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }

    private void FixedUpdate()
    {   //Verificando Pulo
        if (Isgrounded == true)
        {
            anim.SetBool("pulo", false);

            if (Input.GetKey(pulo))
            {
                rigid.AddForce(new Vector2(0f, forcaPulo));
                anim.SetBool("pulo", true);
            }
        }
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        IsPaused = true;

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        IsPaused = false;

    }

    public void Erro()
    {
        textoEr.SetActive(true);
    }
    public void Erro2()
    {
        textoEr2.SetActive(true);
    }
    public void Erro3()
    {
        textoEr3.SetActive(true);
    }
    public void Erro4()
    {
        textoEr4.SetActive(true);
    }
    public void Erro5()
    {
        textoEr5.SetActive(true);
    }

}

