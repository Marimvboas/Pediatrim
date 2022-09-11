using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    public string porta;
    private void OnTriggerEnter2D(Collider2D colisor)
    {
        switch (porta)
        {
            case ("Consultório"):
                {
                    SceneManager.LoadScene("SalaDeConsulta");
                    break;
                }
            case ("Espera"):
                {
                    SceneManager.LoadScene("SalaDeEspera");
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