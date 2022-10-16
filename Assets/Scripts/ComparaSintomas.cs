using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparaSintomas : MonoBehaviour
{
    public static string palavra1="1", palavra2="2";
    public static bool acertou = false;

    public static void ChecarAcerto()
    {
        //if(apertou2){
            if(palavra1.Equals(palavra2))
            {    
                Debug.Log("São iguais");
                acertou = true;
            }
            else
            {
                acertou = false;
                BotaoSintomaPaciente.botaoAcionado = null;
                Debug.Log("São diferentes");
            }
        //}
    }
}
