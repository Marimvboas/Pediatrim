using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageSintDoencas : MonoBehaviour
{
    //public static Text tipoTitulo;
    public static string tipoDoenca="";
    public static bool verDoenca = false;

    public void SelecionouDoenca()
    {
        tipoDoenca = transform.GetChild(0).gameObject.GetComponent<Text>().text;
        verDoenca = true;
        ComparaSintomas.count = 0;
        BotaoSintomaPaciente.proximaDoenca = true;
        ComparaSintomas.acertou = false;
        BotaoSintoma.apertou2 = false;

    }
}
