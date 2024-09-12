using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimentaCaminhao : MonoBehaviour


{ public int vidas;
    public float velocidade, veloDisp, TempoDisparo;
    private Vector3 posicao;
    public Vector3 rotacao;
    public Quaternion rodar;
    private Rigidbody body;
    public Transform Canhao;
    public GameObject tiro;
    public float grauDeRotacao;
    float TempoProxDisparo;
    public UIcontroller HUD;



    public int Vidas
    {
        get { return vidas; }
        set { vidas = value;
            if (vidas < 0) { vidas = 0; }
            if (vidas > 5) { vidas = 5; }
            HUD.AtualizaVida(vidas);
            if (vidas<=0)
            {
                GameOver();
            }

        }
    }


    
    private Rigidbody fisica;

    public float Velocidade
    {
        get { return velocidade;}

        set { velocidade = value;}

    }

    void gira()
    {
        if (Input.GetAxis("Horizontal") > 0.5f) { rodar = Quaternion.Euler(rotacao); }
        else if (Input.GetAxis("Horizontal") < -0.5f) { rodar = Quaternion.Euler(-rotacao); }
        else { rodar = Quaternion.identity; }
    }

    private void movimenta()
    {
        
        float movimentoEmZ = Input.GetAxis("Vertical");
        Vector3 movimento = transform.forward * movimentoEmZ;
        body.velocity = movimento*velocidade;
        transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal") * grauDeRotacao, 0f));

       
    }

    
    private void Atirar()
    {
        if (Input.GetButton("Fire1") && TempoProxDisparo<=0)
        { Instantiate(tiro, Canhao.position, Canhao.rotation);
            TempoProxDisparo = TempoDisparo;
        } 
    }


    // Start is called before the first frame update
    void Start()
    {
        posicao = this.transform.position;
        body = GetComponent<Rigidbody>();
        HUD.AtualizaVida(vidas);

    }

    // Update is called once per frame
    void Update()
    {
        Atirar();
        if(TempoProxDisparo>0)
        {
            TempoProxDisparo -= Time.deltaTime;
        }
    }

    private void GameOver() 
    { 
        SceneManager.LoadScene("GameOver"); 
    }


    private void FixedUpdate()
    {

        movimenta();
        

        
        
    }

    private void OnCollisionEnter(Collision bati)
    
    {
        //Debug.Log(bati.gameObject.name);
    }

}
