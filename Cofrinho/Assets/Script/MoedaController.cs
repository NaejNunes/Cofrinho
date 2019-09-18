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

    PontosController pontosControl;

    public GameObject AuxiliarMultiplic;

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
        //VERIFICA SE A MOEDA FOI ESCOLHIDA.
        if (moedaEscolhida == true)
        {
            //MOVE A MOEDA ESCOLHIDA PARA O PONTO ESCOLHIDO.
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

        //VERIFICA SE A MOEDA ESTA ATIVA
        if (animacaoAtiva == true)
        {
            //INICIA UM CONTADOR PRA DESTRUIR O OBJETO MOEDA
            milesimos -= 1;
            if (milesimos <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //METODO INICIAL APENAS PARA TESTE DE CLIQUES NA BOLINHA
    public void OnMouseDown()
    {        
            moedaEscolhida = true;              
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //ATIVA A ANIMACAO PARA DESTRUIR A BOLINHA
        if (collision.gameObject.CompareTag("DestinoMoeda"))
        {
            animacao.SetBool("DestroiMoeda", true);
            animacaoAtiva = true;
            AudioSource.PlayClipAtPoint(efeitoEstrela, Camera.main.transform.position * Time.deltaTime);
            AudioSource.PlayClipAtPoint(efeitoMoeda, Camera.main.transform.position * Time.deltaTime);
        }        
    }
}
