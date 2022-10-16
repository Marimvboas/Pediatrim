using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sintomas : MonoBehaviour
{

    public Text tipoDoenca;
    int numberSintomas = 6;
    public Text [] sintomas = new Text[6];

    void Start()
    {
        Doenca doenca = new(tipoDoenca.text);
        for(int i=0; i<numberSintomas;i++)
        {
            sintomas[i].text = doenca.Sintomas[i];
        }
    }

    void Update()
    {
        
    }
}

public class Doenca 
{
    string nome;
    public List<string> sintomasDoenca = new();

    public string Nome { get => nome; }
    public List<string> Sintomas { get => sintomasDoenca; }

    public Doenca(string name)
   {
      this.nome = name;
      ListarOsSintomas();
   }

   private void ListarOsSintomas()
   {
       switch(this.nome)
       {
           case ("Linfoma"):{
                sintomasDoenca.Add("Sintoma+1");
                sintomasDoenca.Add("Sintoma+2");
                sintomasDoenca.Add("Sintoma+3");
                sintomasDoenca.Add("Sintoma+4");
                sintomasDoenca.Add("Sintoma+5");
                sintomasDoenca.Add("Sintoma+6");
                break;
            }
            case ("Leucemia"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                break;
            }
            case ("Tumor do Sistema Nervoso Central"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                break;
            }
            case ("Neuroblastoma"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                break;
            }
            case ("Tumor Ósseo"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                break;
            }
            case ("Retinoblastoma"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                break;
            }
       }                    
   }

}
