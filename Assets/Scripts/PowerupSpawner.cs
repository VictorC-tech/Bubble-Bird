using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    [SerializeField]
    private float tempo = 8f;

    [SerializeField]
    private float varAltura = 0.45f;

    [SerializeField]
    private GameObject powerUp;

    private float temporizador;
    void Start()
    {
        SpawnPowerUp();
    }

    void Update()
    {
        if (this.temporizador > this.tempo)
        {
            SpawnPowerUp();
            temporizador = 0;
        }
        temporizador += Time.deltaTime;
    }

    void SpawnPowerUp()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-varAltura, varAltura));
        GameObject powerUp = Instantiate(this.powerUp, spawnPos, Quaternion.identity);

        Destroy(powerUp, 10f);
    }

    
}
