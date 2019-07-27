using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TempoController : MonoBehaviour
{
    public int segundos, milesimos;

    // Start is called before the first frame update
    void Start()
    {
        milesimos = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Tempo();

        if (Time.timeScale == 0)
        {
            segundos = 0;
            milesimos = 0;
        }
    }

    public void Tempo()
    {
        milesimos -= 1;

        if (milesimos <= 0)
        {
            segundos -= 1;
            milesimos = 60;
        }

        if (segundos <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

        var sliderTempo = transform.GetChild(0).GetComponentInChildren<Slider>();
        sliderTempo.value = segundos;    
    }
}
