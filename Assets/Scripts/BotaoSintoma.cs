using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoSintoma : MonoBehaviour
{
    public static string textSintoma;
    public static bool apertou2 = false;

    public void SelecionouSintoma()
    {
        apertou2 = false;
        textSintoma = transform.GetChild(0).gameObject.GetComponent<Text>().text;
        Debug.Log(textSintoma);
        if(BotaoSintomaPaciente.selecionou)
        {
            ComparaSintomas.palavra2 = textSintoma;
            apertou2 = true;
            BotaoSintomaPaciente.selecionou = false;
            BotaoSintomaPaciente.botaoAcionado.GetComponent<Image>().color = Color.white;
            ComparaSintomas.ChecarAcerto();
        }
    }
}
