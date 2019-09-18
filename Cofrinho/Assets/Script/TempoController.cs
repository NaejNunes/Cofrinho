using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TempoController : MonoBehaviour
{
    public int segundos, milesimos;

    PontosController pontosCon;

    // Start is called before the first frame update
    void Start()
    {
        milesimos = 60;  
    }

    // Update is called once per frame
    void Update()
    {
        //Chama o método tempo
        Tempo();

        //Para o tempo caso o jogador acerte a resposta
        if (pontosCon.vitoriacondicao == true)
        {
            Time.timeScale = 0;
        }

        //Para o tempo caso cronometro chegue em zero
        if (segundos <= 0)
        {
            Time.timeScale = 0;
            segundos = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        //Reseta o tempo se o jogo estiver parado.
        if (Time.timeScale == 0)
        {
            segundos = 0;
            milesimos = 0;
        }     
    }

    //Função que faz o tempo correr.
    public void Tempo()
    {
        milesimos -= 1;

        //Reseta o milesimos e tira um do segundos.
        if (milesimos <= 0)
        {
            segundos -= 1;
            milesimos = 60;
        }

        //Liga o tempo corrido com o marcador em jogo.
        var sliderTempo = transform.GetChild(0).GetComponentInChildren<Slider>();
        sliderTempo.value = segundos;     
    }
}
