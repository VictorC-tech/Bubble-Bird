using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeObstaculos : MonoBehaviour
{

    //Como criar os onstáculos?
    //Onde Criar? Na posição de gerador
    //Quando Criar? tempoParaGera
    [SerializeField]
    private float tempoParaGerar = 6f;
    
    private float cronometro;

    [SerializeField]
    private GameObject modeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
