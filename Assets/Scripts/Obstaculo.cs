using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]    
    private float velocidade = 0.8f;
    [SerializeField]
    private float variaçãoPosiçãoY;

    private Vector3 posicaoPassaro;

    // Update is called once per frame
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variaçãoPosiçãoY, variaçãoPosiçãoY));        
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<passaro>().transform.position;
        if(!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            Debug.Log("Pontuou!");
            this.pontuei = true;
        }
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }
}
