using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.3f;

    [SerializeField]
    private float largura = 6f;

    private SpriteRenderer sprite;

    private Vector2 tamanhoInicial;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        tamanhoInicial = new Vector2(sprite.size.x + velocidade + Time.deltaTime, sprite.size.y);

        if (sprite.size.x > largura)
        {
            sprite.size = tamanhoInicial;
        }
    }
}
