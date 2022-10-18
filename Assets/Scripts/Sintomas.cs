using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sintomas : MonoBehaviour
{

    public Text tipoDoenca;
    int numberSintomas = 6;
    public Text [] sintomas = new Text[6];
    public GameObject contentDesc;

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
        contentDesc.GetComponent<Text>().text = doenca.DescriDoenca;
    }
}

public class Doenca 
{
    string nome;
    public List<string> sintomasDoenca = new();
    string descriDoenca;

    public string Nome { get => nome; }
    public string DescriDoenca { get => descriDoenca; }
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
                descriDoenca = "É um câncer que ocorre quando os glóbulos brancos responsáveis pela defesa do nosso corpo contra infecções e outros agentes do sistema imunológico crescem de forma descontrolada. Esta doença ocupa a terceira posição entre cânceres mais comuns na infância, porém os pacientes com linfoma têm alta probabilidade de cura desde que o diagnóstico seja precoce e com baixo grau de disseminação da doença.";
                sintomasDoenca.Add("Aumento do baço");
                sintomasDoenca.Add("Suor noturno");
                sintomasDoenca.Add("Febre");
                sintomasDoenca.Add("Ganglios aumentados");
                sintomasDoenca.Add("Coceira");
                sintomasDoenca.Add("Fadiga");
                break;
            }
            case ("Leucemia"):{
                descriDoenca = "Gerada pelo acúmulo de células doentes na medula óssea, causado por uma mutação genética que as transformam em células cancerosas, que substituem as células sanguíneas normais. Consequentemente pode resultar na diminuição de glóbulos brancos ou vermelhos.";
                sintomasDoenca.Add("Cansaço");
                sintomasDoenca.Add("Febre");
                sintomasDoenca.Add("Dores na gengiva");
                sintomasDoenca.Add("Perda de apetite");
                sintomasDoenca.Add("Perda de peso");
                sintomasDoenca.Add("Inchaços no corpo");
                break;
            }
            case ("Tumor do SNC"):{
                descriDoenca = "Ocorrem devido ao crescimento de células anormais no tecido do cérebro, da medula espinhal e das meninges (membranas que revestem o sistema nervoso central, o tronco encefálico e o encéfalo) de forma descontrolada. Quase 90% destes tumores malignos se desenvolvem no cérebro. É o tumor sólido mais comum na infância. O pico de incidência encontra-se na faixa etária de um a quatro anos.";
                sintomasDoenca.Add("Náuseas");
                sintomasDoenca.Add("Vômitos");
                sintomasDoenca.Add("Paralisia de pares cranianos");
                sintomasDoenca.Add("Hipertensão Intracraniana");
                sintomasDoenca.Add("Não ganho de peso em bebê");
                sintomasDoenca.Add("Macrocefalia em bebê");
                break;
            }
            case ("Neuroblastoma"):{
                descriDoenca = "É uma forma de câncer que se inicia precocemente nas células nervosas encontradas em um embrião ou feto em desenvolvimento, sendo responsável por cerca de 6% dos cânceres infantis. Diagnosticado em crianças com mais de 10 anos. Frequente surgir no abdômen, no tórax, na pele ou na medula espinhal.";
                sintomasDoenca.Add("");
                sintomasDoenca.Add("Febre");
                sintomasDoenca.Add("Dor Óssea");
                sintomasDoenca.Add("Inchaços no corpo");
                sintomasDoenca.Add("Estufamento abdominal");
                sintomasDoenca.Add("");
                break;
            }
            case ("Tumor Ósseo"):{
                descriDoenca = "É uma massa de células anormais produzidas no tecido ósseo. Possuem vários tipos de tumores ósseos, e sua nomenclatura depende da localização do osso, do tipo de células que formam o tumor, e até do tecido adjacente atingido em caso de metástase (processo no qual as células cancerosas soltam-se do tumor original e vão para outras partes do corpo). Podem ser benignos ou malignos.";
                sintomasDoenca.Add("Dor na região afetada");
                sintomasDoenca.Add("Inchaço na região afetada");
                sintomasDoenca.Add("Fraturas");
                sintomasDoenca.Add("Perda de peso");
                sintomasDoenca.Add("Dormência/Formigamento");
                sintomasDoenca.Add("Nódulo na região afetada");
                break;
            }
            case ("Retinoblastoma"):{
                descriDoenca = "É um tipo raro de câncer ocular. Existem três tipos de retinoblastoma, a maioria dos casos, entre 60% e 75%, é unilateral, quando afeta um olho. Destes, 85% são esporádicos, e os demais são casos hereditários. Já o bilateral é quando os dois olhos são afetados, sendo quase sempre hereditário. Já o retinoblastoma trilateral, é quando uma criança com tumor hereditário nos dois olhos também apresenta tumor associado às células nervosas primitivas do cérebro.";
                sintomasDoenca.Add("Heterocromia");
                sintomasDoenca.Add("Leucocoria");
                sintomasDoenca.Add("Sangramento no olho");
                sintomasDoenca.Add("Estrabismo");
                sintomasDoenca.Add("Fotofobia");
                sintomasDoenca.Add("Vermelhidão no olho");
                break;
            }
            default:{
                break;
            }
       }                    
   }

}
