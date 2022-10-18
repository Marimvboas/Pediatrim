using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageSintomasPaciente : MonoBehaviour
{
    //static bool examesFeitos = false; //muda pra true ao acabar o exame apenas
    int numberSintomas = 4;
    public Text [] sintomas = new Text[4]; //os textos dos botoes dos sintomas do paciente
    public GameObject [] sintomasBut = new GameObject[4]; //os botoes dos sintomas do paciente

    void Start() 
    {
        if(MouseEmboloSangue.finalizou)
        {
            for(int i=0; i<numberSintomas;i++)
            {
                sintomasBut[i].SetActive(true);
                sintomas[i].text = KidInstante.paciente.Sintomas[i];
                //sintomas[i].text = $"Sintoma+{i}";
            }
        }
        else
        {
           for(int i=0; i<numberSintomas;i++)
            {
                sintomasBut[i].SetActive(false);
            } 
        }
        
    }

    void Update()
    {
        
       if(MouseEmboloSangue.finalizou)
       {
           if(ManageSintDoencas.verDoenca){
            for(int i=0; i<numberSintomas;i++)
            {
                sintomasBut[i].SetActive(true);
            } 
            }
       } else {
           for(int i=0; i<numberSintomas;i++)
            {
                sintomasBut[i].SetActive(false);
            } 
       }
        
    }
}
