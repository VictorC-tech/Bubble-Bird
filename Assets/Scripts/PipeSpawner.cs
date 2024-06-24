using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private float tempo = 1.5f;

    [SerializeField]
    private float varAltura = 0.45f;

    [SerializeField]
    private GameObject pipe;

    private float temporizador;

    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.temporizador > this.tempo)
        {
            SpawnPipe();
            temporizador = 0;
        }
        temporizador += Time.deltaTime;
    }

    void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3 (0, Random.Range(-varAltura, varAltura));
        GameObject pipe = Instantiate(this.pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
