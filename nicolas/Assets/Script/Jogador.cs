using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public bool Jogadores;
    public float VeloJogador;
    public float limiteInferior, limiteSuperior;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Jogadores == false)
        {
            MovimentoDoJogador1();
        }
        if (Jogadores == true)
        {
            MovimentoDoJogador2();
        }


    }

    public void MovimentoDoJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteInferior, limiteSuperior));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * VeloJogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * VeloJogador * Time.deltaTime);
        }
    }

    public void MovimentoDoJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, limiteInferior, limiteSuperior));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * VeloJogador * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * VeloJogador * Time.deltaTime);
        }
    }
   

}

