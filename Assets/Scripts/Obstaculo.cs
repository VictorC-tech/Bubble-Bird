using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]    
    private float velocidade = 0.8f;
    [SerializeField]
    private float variaçãoPosiçãoY;
    // Update is called once per frame

    private void Start()
    {
        
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variaçãoPosiçãoY, variaçãoPosiçãoY));        
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
