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
        // tipoDoenca.text = ManageSintDoencas.tipoDoenca;
        // Doenca doenca = new(tipoDoenca.text);
        // for(int i=0; i<numberSintomas;i++)
        // {
        //     sintomas[i].text = doenca.Sintomas[i];
        // }
    }

    void Update()
    {
        if(ManageSintDoencas.verDoenca){
            GerarDadosDoenca();
            ManageSintDoencas.verDoenca=false;
        }
    }

    public void GerarDadosDoenca()
    {
        tipoDoenca.text = ManageSintDoencas.tipoDoenca;
        Doenca doenca = new(tipoDoenca.text);
        for(int i=0; i<numberSintomas;i++)
        {
            sintomas[i].text = doenca.Sintomas[i];
        }
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
                sintomasDoenca.Add("Aumento do baço");
                sintomasDoenca.Add("Sintoma2");
                sintomasDoenca.Add("Febre");
                sintomasDoenca.Add("Sintoma4");
                sintomasDoenca.Add("Coceira");
                sintomasDoenca.Add("Sintoma6");
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
            case ("Tumor do SNC"):{
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
                sintomasDoenca.Add("Febre");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Sensação de estufamento abdominal");
                sintomasDoenca.Add("Inchaço");
                break;
            }
            case ("Tumor Ósseo"):{
                sintomasDoenca.Add("Dor na região afetada");
                sintomasDoenca.Add("Inchaço na região afetada");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Perda de peso");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Nódulo na região afetada");
                break;
            }
            case ("Retinoblastoma"):{
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Leucocoria");
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Estrabismo");
                sintomasDoenca.Add("Fotofobia");
                sintomasDoenca.Add("");
                break;
            }
            default:{
                break;
            }
       }                    
   }

}
