using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PontosController : MonoBehaviour
{
    private int moedasQTD, qtdErro;

    public int qtdMax, CondicaoVitoria;

    public Text txtMoedasQTD;

    // Start is called before the first frame update
    void Start()
    {
        qtdErro = 3;
    }

    // Update is called once per frame
    void Update()
    {
        txtMoedasQTD.text = "" + moedasQTD +"/"+ qtdMax;

        if (moedasQTD == CondicaoVitoria)
        {
            SceneManager.LoadScene("Fase2");
        }
        if (moedasQTD > qtdMax)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("AdMoeda1"))
        {
            moedasQTD += 1;
        }

        if (collision.gameObject.CompareTag("AdMoeda2"))
        {
            moedasQTD += 2;
        }

        if (collision.gameObject.CompareTag("AdMoeda3"))
        {
            moedasQTD += 3;
        }

        if (collision.gameObject.CompareTag("AdMoeda4"))
        {
            moedasQTD += 4;
        }

        if (collision.gameObject.CompareTag("AdMoeda5"))
        {
            moedasQTD += 5;
        }

        if (collision.gameObject.CompareTag("AdMoeda6"))
        {
            moedasQTD += 6;
        }

        if (collision.gameObject.CompareTag("AdMoeda7"))
        {
            moedasQTD += 7;
        }

        if (collision.gameObject.CompareTag("AdMoeda8"))
        {
            moedasQTD += 8;
        }

        if (collision.gameObject.CompareTag("AdMoeda9"))
        {
            moedasQTD += 9;
        }

        if (collision.gameObject.CompareTag("AdMoeda10"))
        {
            moedasQTD += 10;
        }
    }
}
