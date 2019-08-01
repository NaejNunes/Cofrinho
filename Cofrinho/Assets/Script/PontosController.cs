using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PontosController : MonoBehaviour
{
    private int moedasQTD;

    public int qtdMax, CondicaoVitoria;

    public Text txtMoedasQTD;

    public GameObject fimDeJogo;

    public AudioClip audioError, audioVictory;

    TempoController TempoCon;

    public bool vitoria;



    // Start is called before the first frame update
    void Start()
    {
        vitoria = false;
    }

    // Update is called once per frame
    void Update()
    {
        txtMoedasQTD.text = "" + moedasQTD +"/"+ qtdMax;

        if (moedasQTD == CondicaoVitoria)
        {
            AudioSource.PlayClipAtPoint(audioVictory, Camera.main.transform.position * Time.deltaTime);
            Time.timeScale = 0;
            fimDeJogo.SetActive(true);
            moedasQTD = -1;
            vitoria = true;          
        }

        if (moedasQTD == -1)
        {
            Time.timeScale = 0;
        }
        if (moedasQTD > qtdMax)
        {
            moedasQTD = -1;           
            AudioSource.PlayClipAtPoint(audioError, Camera.main.transform.position * Time.deltaTime);
            fimDeJogo.SetActive(true);
            SceneManager.LoadScene("Menu");
        }
        else
        {
            Time.timeScale = 1;

        }
         if (moedasQTD == -1)
        {
            Time.timeScale = 0;
            txtMoedasQTD.text = "0" + "/" + qtdMax;
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

        if (collision.gameObject.CompareTag("SubMoeda1"))
        {
            moedasQTD -= 1;
        }

        if (collision.gameObject.CompareTag("SubMoeda2"))
        {
            moedasQTD -= 2;
        }

        if (collision.gameObject.CompareTag("SubMoeda3"))
        {
            moedasQTD -= 3;
        }

        if (collision.gameObject.CompareTag("SubMoeda4"))
        {
            moedasQTD -= 4;
        }

        if (collision.gameObject.CompareTag("SubMoeda5"))
        {
            moedasQTD -= 5;
        }

        if (collision.gameObject.CompareTag("SubMoeda6"))
        {
            moedasQTD -= 6;
        }

        if (collision.gameObject.CompareTag("SubMoeda7"))
        {
            moedasQTD -= 7;
        }

        if (collision.gameObject.CompareTag("SubMoeda8"))
        {
            moedasQTD -= 8;
        }

        if (collision.gameObject.CompareTag("SubMoeda9"))
        {
            moedasQTD -= 9;
        }

        if (collision.gameObject.CompareTag("SubMoeda10"))
        {
            moedasQTD -= 10;
        }
    }
}
