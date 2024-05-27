using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posI;
    private float realSize;
    // Start is called before the first frame update
    void Start()
    {
       this.posI = this.transform.position;
       float imageSize = GetComponent<SpriteRenderer>().size.x;
       float escala = this.transform.localScale.x;
       this.realSize = imageSize * escala;

    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, realSize);
        this.transform.position = this.posI + Vector3.left * deslocamento;
    }
}
