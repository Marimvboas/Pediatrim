using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour
{
    private float tempoInicial = 0f;
    private float tempoFinal = 0f;
    public static bool acabouOTempo = false;
    [SerializeField] GameObject buttonReinicia, barraConfianca, estetos, posBarra, buttonGameOver;
    bool reiniciar = false;
    public AudioSource aud;
    
    void Awake()
    {
        acabouOTempo = false;
        tempoInicial = Time.time;
        tempoFinal = Time.time;
        Debug.Log(tempoInicial);
        buttonReinicia.SetActive(false);
        buttonGameOver.SetActive(false);
        estetos.SetActive(true);
        DistanceAudio.terminouExame = false;
        barraConfianca.transform.localScale = new Vector3(Player.pontoConfianca, 1f, 1f);
        barraConfianca.transform.position = posBarra.transform.position;
        reiniciar = false;
        
    }

    
    void Update()
    {
        tempoFinal = Time.time;
        Debug.Log(tempoFinal-tempoInicial);

        if(Player.pontoConfianca==0){
            Player.pontoConfianca = 1f;
            buttonGameOver.SetActive(true);

        } else if((tempoFinal-tempoInicial>=20f)&&(!DistanceAudio.terminouExame)&&(!reiniciar)){
            Debug.Log("Acabou o tempo");
            acabouOTempo = true;
            Player.pontoConfianca -= 0.25f;
            buttonReinicia.SetActive(true);
            estetos.SetActive(false);
            reiniciar = true;
            aud.Play();
            //barraConfianca.transform.localScale = new Vector3(Player.pontoConfianca, 1f, 1f);
        }
        
    }
}
