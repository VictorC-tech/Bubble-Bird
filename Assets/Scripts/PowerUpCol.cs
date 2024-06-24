using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCol : MonoBehaviour
{
    public float shieldDuration = 5f;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Passaro player = other.GetComponent<Passaro>();
            if (player != null)
            {
                player.ActivateShield(shieldDuration);
                gameObject.SetActive(false);
            }
        }
    }
}
