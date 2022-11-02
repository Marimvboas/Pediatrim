using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour
{
    private float tempoInicial = 0;
    private float tempoFinal = 0;
    public static bool acabouOTempo = false;
    // Start is called before the first frame update
    void Start()
    {
        tempoInicial = Time.time;
        Debug.Log(tempoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        tempoFinal = Time.time;
        Debug.Log(tempoFinal);
        if(tempoFinal-tempoInicial>=300f){
            Debug.Log("Acabou o tempo");
            acabouOTempo = true;
        }
    }
}
