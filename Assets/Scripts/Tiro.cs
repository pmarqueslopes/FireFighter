using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public int dano;
    public float velocidadeTiro;
    private Vector3 posicao;
    private void Movimenta()
    {
        
        this.transform.position+= transform.forward* velocidadeTiro;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            other.GetComponent<InimigoScript>().VidaInimigo -= dano;
        }
        if (other.gameObject.CompareTag("Inimigo"))

        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("InimigoPanela"))
        {
            other.GetComponent<Scriptpanela>().VidasPanela -= dano;
        }
        if (other.gameObject.CompareTag("InimigoPanela"))

        {
            Destroy(this.gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        posicao = this.transform.position;
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Movimenta();
    }
}
