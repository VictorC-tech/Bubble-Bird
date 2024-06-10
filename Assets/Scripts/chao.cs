using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.9f;

    private Vector3 posicaoInicial;
    private float tamanhoReal;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoReal = GetComponent<SpriteRenderer>().size.x;
        float tamanhoDaImgagem = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoReal = tamanhoDaImgagem * escala;
    }

    // Update is called once per frame
    void Update()
    {
            float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoReal);
            this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}