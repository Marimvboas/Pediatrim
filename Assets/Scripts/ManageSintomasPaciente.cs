using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageSintomasPaciente : MonoBehaviour
{
    static bool examesFeitos = true;
    int numberSintomas = 4;
    public Text [] sintomas = new Text[4];

    void Start() 
    {
        if(examesFeitos)
        {
            for(int i=0; i<numberSintomas;i++)
            {
                //sintomas[i].text = KidInstante.paciente.Sintomas[i];
                sintomas[i].text = $"Sintoma+{i}";
            }
        }
        
    }

    void Update()
    {
        

    }
}
