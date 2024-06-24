using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private Passaro passaro;

    [SerializeField]
    private GameObject gameOverCanvas;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
   
    public void RestardGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(ResetPlayerAfterRestart());
    }
    private IEnumerator ResetPlayerAfterRestart()
    {
        yield return new WaitForSeconds(0.1f); // Pequeno atraso para garantir que a cena seja recarregada
        passaro = FindObjectOfType<Passaro>();
        passaro.ResetPlayer();
    }
}
