using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public static Pontuacao instance;

    [SerializeField]
    private TextMeshProUGUI pontuacaoAtual;

    [SerializeField]
    private TextMeshProUGUI pontuacaoMaxTXT;

    private int pontuacao;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        pontuacaoAtual.text = pontuacao.ToString();

        pontuacaoMaxTXT.text = PlayerPrefs.GetInt("MelhorPontuacao", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if(pontuacao > PlayerPrefs.GetInt("MelhorPontuacao"))
        {
            PlayerPrefs.SetInt("MelhorPontuacao", pontuacao);
            pontuacaoMaxTXT.text = pontuacao.ToString();
        }
    }

    public void UpdatePontuacao()
    {
        pontuacao++;
        pontuacaoAtual.text = pontuacao.ToString();
        UpdateHighScore();
    }
}
