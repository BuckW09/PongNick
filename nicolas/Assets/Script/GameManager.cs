using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text tempo;
    public bool isGameOver = false;
    public int temporizador;
    public Text pontuacao;
    public AudioSource pont;
    public float Jogador1;
    public float Jogador2;
    public GameObject TelaPause;
    public GameObject TelaGameOver;

    // Start is called before the first frame update
    void Start()
    {
        TelaPause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tempo.text = temporizador.ToString();
        temporizador = 60 - (int)Time.time;
        GameOver();
        //TelaPauseCondicao();
    }
   
    public void GameOver()
    {
        if (temporizador <= 0) 
        {

            isGameOver = true;
            TelaPause.SetActive(false);
            TelaGameOver.SetActive(true);
            Time.timeScale = 0;
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausarJogo();
        }
    }
    public void pontuacaoJg1()
    {
        Jogador1++;
        pontuacaoAtu();
    }
    public void pontuacaoJg2()
    {
        Jogador2++;
        pontuacaoAtu();
    }
    public void pontuacaoAtu()
    {
        pontuacao.text = Jogador1.ToString() + "x" + Jogador2.ToString();
        //pont.Play();
    }

   

    public void PausarJogo()
    {
        if(Time.timeScale == 1 )
        {
            Time.timeScale = 0;
            TelaPause.SetActive(true);
        }
        else if( Time.timeScale == 0)
        {
            Time.timeScale = 1;
            TelaPause.SetActive(false) ;
        }
    }
}
