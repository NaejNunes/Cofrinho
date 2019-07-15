using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontosController : MonoBehaviour
{
    private int moedasQTD;

    public Text txtMoedasQTD;

    public GameObject[] moedaHUD;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtMoedasQTD.text = "" + moedasQTD + "/60";

        if (moedasQTD > 60)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moeda1"))
        {
            moedasQTD += 1;
        }

        if (collision.gameObject.CompareTag("Moeda20"))
        {
            moedasQTD += 20;
        }
    }
}
