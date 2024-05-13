using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : MonoBehaviour
{
    Rigidbody2D fisica;
    private void Awake()
    {
      this.fisica = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            this.impulsionar();
        }
    }
    void impulsionar()
    {
        this.fisica.AddForce(Vector2.up*3,ForceMode2D.Impulse);
    }
}
