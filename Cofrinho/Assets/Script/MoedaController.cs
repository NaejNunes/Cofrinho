using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoedaController : MonoBehaviour
{   
    bool moedaEscolhida, animacaoAtiva;

    public Transform[] wayPoints;

    int cur, milesimos, segundos;

    public float speed;

    private Animator animacao;

    public AudioClip efeitoMoeda, efeitoEstrela;

   // public AudioClip efeitoMoeda, efeitoEstrela;
    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();

        moedaEscolhida = false;
        animacaoAtiva = false;

        milesimos = 18;
        segundos = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(segundos + ":" + milesimos);

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

        if (animacaoAtiva == true)
        {
            milesimos -= 1;
            if (milesimos <= 0)
            {
                Destroy(gameObject);
            }
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
           // efeitoEstrela.Play();
            //efeitoMoeda.Play();
            animacao.SetBool("DestroiMoeda", true);
            animacaoAtiva = true;               
        }
    }
}
