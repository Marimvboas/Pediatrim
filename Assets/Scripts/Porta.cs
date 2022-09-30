using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    public string porta;
    public GameObject telaDeInteracao;

    private void Start()
    {
        telaDeInteracao.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D colisor)
    {
        Debug.Log("Aperte E");
        telaDeInteracao.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (porta)
            {
                case ("Consultorio"):
                    {
                        PlayerPosition.pos = 1;
                        SceneManager.LoadScene("SalaDeConsulta", LoadSceneMode.Single);
                        break;
                    }
                case ("Espera"):
                    {
                        PlayerPosition.pos = 2;
                        SceneManager.LoadScene("SalaDeEspera", LoadSceneMode.Single);
                        break;
                    }
                case ("Casa"):
                    {
                        PlayerPosition.pos = 1;
                        SceneManager.LoadScene("Casa", LoadSceneMode.Single);
                        break;
                    }
                default:
                    {
                        Debug.Log("Default Porta");
                        break;
                    }
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D colisor)
    {
        telaDeInteracao.SetActive(false);
    }
}