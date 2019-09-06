using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PontosController : MonoBehaviour
{
    public int moedasQTD;

    public int qtdMax, condicaoVitoria;

    public Text txtMoedasQTD;

    public GameObject vitoria, derrota;

    public AudioClip audioError, audioVictory;

    TempoController TempoCon;

    public bool vitoriacondicao, soma, subtracao, multiplicacao, divisao, condicaoSubtracao;



    // Start is called before the first frame update
    void Start()
    {
        vitoriacondicao = false;

        condicaoSubtracao = false;

        if (multiplicacao == true)
        {
            moedasQTD = 1;

            txtMoedasQTD.text = "0/" + qtdMax;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (multiplicacao == true && moedasQTD > 1)
        {
            txtMoedasQTD.text = moedasQTD + "/" + qtdMax; 
        }
        if(soma == true || subtracao == true)
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;
        }

        if (moedasQTD == condicaoVitoria && soma == true)
        {
            AudioSource.PlayClipAtPoint(audioVictory, Camera.main.transform.position * Time.deltaTime);
            Time.timeScale = 0;
            vitoria.SetActive(true);
            moedasQTD = -1;
            vitoriacondicao = true;
        }

        else if (moedasQTD == condicaoVitoria && subtracao == true)
        {
            AudioSource.PlayClipAtPoint(audioVictory, Camera.main.transform.position * Time.deltaTime);
            Time.timeScale = 0;
            vitoria.SetActive(true);
            condicaoSubtracao = true;
            vitoriacondicao = true;
        }

        else if (moedasQTD == condicaoVitoria && multiplicacao == true)
        {
            AudioSource.PlayClipAtPoint(audioVictory, Camera.main.transform.position * Time.deltaTime);
            Time.timeScale = 0;
            vitoria.SetActive(true);
            moedasQTD = -1;
            vitoriacondicao = true;
        }
       

        if (soma == true && moedasQTD > qtdMax || multiplicacao == true && moedasQTD > qtdMax ) 
        {
            moedasQTD = -1;           
            AudioSource.PlayClipAtPoint(audioError, Camera.main.transform.position * Time.deltaTime);
            derrota.SetActive(true);        
        }
        else if (subtracao == true && moedasQTD < qtdMax  )
        {
            condicaoSubtracao = true;
            AudioSource.PlayClipAtPoint(audioError, Camera.main.transform.position * Time.deltaTime);
            derrota.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
        }

         if (moedasQTD == -1 && soma == true || moedasQTD == -1 && multiplicacao == true)
        {
            Time.timeScale = 0;
            txtMoedasQTD.text = "0" + "/" + qtdMax;
        }
        else if (condicaoSubtracao == true && subtracao == true)
        {
            moedasQTD = 1;
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

        if (collision.gameObject.CompareTag("MPMoeda1"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 1;
        }
        if (collision.gameObject.CompareTag("MPMoeda2"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 2;
        }
        if (collision.gameObject.CompareTag("MPMoeda3"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 3;
        }
        if (collision.gameObject.CompareTag("MPMoeda4"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 4;
        }
        if (collision.gameObject.CompareTag("MPMoeda5"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 5;
        }
        if (collision.gameObject.CompareTag("MPMoeda6"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 6;
        }
        if (collision.gameObject.CompareTag("MPMoeda7"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 7;
        }
        if (collision.gameObject.CompareTag("MPMoeda8"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 8;
        }
        if (collision.gameObject.CompareTag("MPMoeda9"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 9;
        }
        if (collision.gameObject.CompareTag("MPMoeda10"))
        {
            txtMoedasQTD.text = "" + moedasQTD + "/" + qtdMax;

            moedasQTD *= 10;
        }
    }
}
