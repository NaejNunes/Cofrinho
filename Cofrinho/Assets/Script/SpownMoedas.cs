using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownMoedas : MonoBehaviour
{
    public GameObject[] moeda;

    public static float x, y;

    int numeroMoedas;
    // Start is called before the first frame update
    void Start()
    {
        SpownMoeda();
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
    }

    public void SpownMoeda()
    {
        numeroMoedas = Random.Range(1, 1);

        switch (numeroMoedas)
        {
            case 1:
                 Instantiate(this.moeda[0], new Vector2(SpownMoedas.x + 0f, SpownMoedas.y +0f), Quaternion.identity);            
                 break;
        }
    }
}
