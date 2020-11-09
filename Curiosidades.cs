using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curiosidades : MonoBehaviour
{

    public GameObject curio1;
    public GameObject curio2;
    public GameObject curio3;
    public GameObject curio4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "curio1")
        {
            curio1.SetActive(true);
        }
        if (collision.transform.tag == "curio2")
        {
            curio2.SetActive(true);
        }
        if (collision.transform.tag == "curio3")
        {
            curio3.SetActive(true);
        }
        if (collision.transform.tag == "curio4")
        { 
            curio4.SetActive(true);
        }
    }
    public void fechar()
    {
        curio1.SetActive(false);
    }
    public void fechar2()
    {
        curio2.SetActive(false);
    }
    public void fechar3()
    {
        curio3.SetActive(false);
    }
    public void fechar4()
    {
        curio4.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
