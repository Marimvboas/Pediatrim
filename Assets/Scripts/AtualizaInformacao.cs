using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtualizaInformacao : MonoBehaviour
{

    private void Update()
    {
        if(KidInstante.kid!=null){
            gameObject.GetComponent<Text>().text = $"Paciente   |\n ________________ \nNome: {KidInstante.paciente.Nome}\nIdade: {KidInstante.paciente.Idade}\nAltura: {KidInstante.paciente.Altura}\nPeso(Kg): {KidInstante.paciente.Peso}\nSexo: {KidInstante.paciente.Sexo}\n________________";
        }
        
    }

    private void Start()
    {
        
    }

}
