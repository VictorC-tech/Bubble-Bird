using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Passaro : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.6f;

    [SerializeField]
    private float rotacao = 10f;

    public bool isShielded = false;
    private float shieldTimeLeft;
    private Coroutine shieldCoroutine;
    private Rigidbody2D rb;
    private SpriteRenderer sr;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * velocidade;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0, rb.velocity.y * rotacao);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (isShielded)
            {
                // Destruir o obstáculo
                Destroy(collision.gameObject);
                // Desativa o escudo após colidir com o obstáculo
                StartCoroutine(DisableShield());
            }
            else
            {
                GameManager.instance.GameOver();
            }
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.instance.GameOver();
        }

    }
    public void ActivateShield(float duration)
    {
        if (shieldCoroutine != null)
        {
            StopCoroutine(shieldCoroutine);
        }
        shieldCoroutine = StartCoroutine(Shield(duration));
    }
    private IEnumerator Shield(float duration)
    {
        isShielded = true;
        shieldTimeLeft = duration;
        
        sr.color = Color.blue;

        yield return new WaitForSeconds(duration);

        while (shieldTimeLeft > 0)
        {
            shieldTimeLeft -= Time.deltaTime;
            yield return null;
        }
        StartCoroutine(DisableShield());
    }

    private IEnumerator DisableShield()
    {
        isShielded = false;
        sr.color = Color.white;
        yield return null;
    }
    public void ResetPlayer()
    {
        rb.velocity = Vector2.zero;
        rb.position = new Vector2(0, 0); 
        if (shieldCoroutine != null)
        {
            StopCoroutine(shieldCoroutine);
        }
        isShielded = false;
        sr.color = Color.white; 
    }

}
