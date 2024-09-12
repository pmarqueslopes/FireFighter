using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo : MonoBehaviour
{ 
public int danoInimigo;
public float velocidadeTiroInimigo;
private Vector3 posicao;
private void Movimenta()
{

        this.transform.position += transform.forward * velocidadeTiroInimigo;
        
}


private void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        other.GetComponent<MovimentaCaminhao>().Vidas -= danoInimigo;
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