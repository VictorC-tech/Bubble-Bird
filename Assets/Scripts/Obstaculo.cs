using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]    
    private float velocidade = 0.8f;
    [SerializeField]
    private float variaçãoPosiçãoY;

    private bool pontuei;

    private Vector3 posicaoPassaro;

    private UiController uicontroller;

    // Update is called once per frame
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variaçãoPosiçãoY, variaçãoPosiçãoY));        
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<passaro>().transform.position;
        this.uicontroller = GameObject.FindObjectOfType<UiController>();
    }

    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {
            this.uicontroller.adicionarPonto();
            this.pontuei = true;
        }
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
