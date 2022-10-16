using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoSintomaPaciente : MonoBehaviour
{

    public static string textSintoma;
    public static bool selecionou = false;
    public static GameObject botaoAcionado;
    public static bool proximaDoenca = false;

    public void Update()
    {
        if(ComparaSintomas.acertou && BotaoSintoma.apertou2)
        {
            botaoAcionado.SetActive(false);
            selecionou = false;
        }
        else{
            botaoAcionado.SetActive(true);
        }

        if(proximaDoenca)
        { //acho q esse if nao ta funcionando nao, tipo, nao serve pra nada
            gameObject.SetActive(true);
            proximaDoenca = false;
        }
    }

    public void SelecionouSintoma()
    {
        BotaoSintoma.apertou2 = false;
        selecionou = true;
        textSintoma = transform.GetChild(0).gameObject.GetComponent<Text>().text;
        Debug.Log(textSintoma);
        ComparaSintomas.palavra1 = textSintoma;
        botaoAcionado = gameObject;
    }
}
