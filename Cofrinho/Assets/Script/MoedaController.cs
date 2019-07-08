using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaController : MonoBehaviour
{   
    bool moedaEscolhida;

    public Transform[] wayPoints;

    int cur;

    public float speed;

    private Animator animacao;
    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();

        moedaEscolhida = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moedaEscolhida == true)
        {
            if (transform.position != wayPoints[cur].position)
            {
                Vector2 p = Vector2.MoveTowards(transform.position, wayPoints[cur].position, speed);
                GetComponent<Rigidbody2D>().MovePosition(p);
            }
            else
            {
                cur = (cur + 1) % wayPoints.Length;
            }

            Vector2 dir = wayPoints[cur].position - transform.position;
            GetComponent<Animator>().SetFloat("DirX", dir.x);
            GetComponent<Animator>().SetFloat("DirY", dir.y);
        }
    }

    public void OnMouseDown()
    {        
            moedaEscolhida = true;              
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DestinoMoeda"))
        {
            animacao.SetBool("DestroirMoeda", true);
            Destroy(gameObject);
        }
    }
}
