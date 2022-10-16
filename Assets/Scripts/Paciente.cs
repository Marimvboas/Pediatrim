using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciente : MonoBehaviour
{
    [SerializeField] string nome, idade, altura, peso, sexo;
    [SerializeField] string [] sintomas = new string[4];
    
    public string Nome { get => nome; }
    public string Idade { get => idade; }
    public string Altura { get => altura; }
    public string Peso { get => peso; }
    public string Sexo { get => sexo; }
    public string [] Sintomas { get => sintomas; }

}
