using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<MovimentaCaminhao>().Vidas += 1;
            Destroy(this.gameObject);
        }



        // Start is called before the first frame update
        void Start()
        {

        }

    }
}