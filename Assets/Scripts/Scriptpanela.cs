using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptpanela : MonoBehaviour
{

    int vidasPanela = 4;
    public Transform Personagem;
     public float VelocidadePanela;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<MovimentaCaminhao>().Vidas -= 1;

        }
    }

    private void Morrer()
    {
        Destroy(this.gameObject);
    }
    public int VidasPanela
    {
        get { return vidasPanela; }
        set
        {
            vidasPanela = value;
            if (vidasPanela <= 0)
            {
                Morrer();
            }
        }
    }



    void Movimenta()
    {
        transform.Translate(transform.forward * VelocidadePanela*Time.deltaTime);
        
        transform.LookAt(Personagem);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimenta();
    }



}
