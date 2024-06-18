using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    // Start is called before the first frame update
    void Start()
    {
        GameOver();
    }

    // Update is called once per frame
    void Update()
    {
        tempo.text = temporizador.ToString();
        temporizador = 60 - (int)Time.time;
    }
    public void isGameOver() { }
    public void GameOver()
    {
        if (temporizador <= 0) 
        {
            isGameOver = true;
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
        pont.Play();
    }
}
