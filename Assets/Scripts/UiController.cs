using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UiController : MonoBehaviour
{

    private int pontos;
    private Label textoPontuacao;
    

    public void adicionarPonto()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("Pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
