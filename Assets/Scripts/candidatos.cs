using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candidatos : MonoBehaviour
{
    [SerializeField]    
    private float velocidade = 0.8f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * velocidade * Time.deltaTime);
        this.transform.Translate(Vector3.up * Random.Range(-0.003f, 0.003f));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.DestruirCandidato();
    }

    private void DestruirCandidato()
    {
        Destroy(this.gameObject);
    }
}
