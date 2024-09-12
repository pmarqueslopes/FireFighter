using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour
{
    // Start is called before the first frame update

   
    private int vidaInimigo = 2;
    float TempoProxDisparoInimigo;
    public float TempoDisparoInimigo;
    public GameObject TiroInimigo;
    public Transform CanhaoInimigo;
    public Transform Personagem;

    private void Morrer()
    {
        Destroy(this.gameObject);
    }


    private void Atirar()
        {


        if (TempoProxDisparoInimigo <= 0)
        {
            Instantiate(TiroInimigo, CanhaoInimigo.position, CanhaoInimigo.rotation);
            TempoProxDisparoInimigo = TempoDisparoInimigo;
        }
         
        }

        public int VidaInimigo { 
        get { return vidaInimigo; }
        set
        {
            vidaInimigo = value;
            if(vidaInimigo <= 0)
            {
                Morrer();
            }
        }
                                     }
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Atirar();
    if (TempoProxDisparoInimigo > 0)
     {
        TempoProxDisparoInimigo -= Time.deltaTime;
     }

        Movimenta();
    }

   private void  Movimenta()
    {
        transform.LookAt(Personagem);
    }
    
}