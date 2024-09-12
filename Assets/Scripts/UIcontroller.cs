using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{


    public Text VidasText;


    public void CarregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void Quit() 
    {
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
       // VidasText = GetComponent<MovimentaCaminhao>().vidas;
    }

    // Update is called once per frame
   public void AtualizaVida(int Vida)
    {
        VidasText.text = Vida.ToString();
    }
}
