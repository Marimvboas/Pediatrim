using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidInstante : MonoBehaviour
{
    public static Paciente paciente;
    public static GameObject pacienteObject;
    public static KidInstante Instance;
    public static List<GameObject> pacientes;
    public static bool blockInstantiateKid = true;
    //public static bool blockSetaVerde = false;
    //public static GameObject setaVerde;

    void Awake() 
    {
        if(pacientes == null && Player.day == 0)
        {   
            KidInstante.pacientes = new List<GameObject>();

            KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Gustavo"));
            KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Joao"));
            KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Luana da Silva"));
            KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Maria Eduarda"));

            //InstanciaPirralho();
        }
        //setaVerde = GameObject.Find("SetaVerde");
    }

    void Start()
    { 

        if(paciente == null && !blockInstantiateKid)
        {
            
            InstanciaPirralho();
            
        } 
        // else if(paciente==null&&blockSetaVerde){
        //     GameObject.Find("SetaVerde").SetActive(false);
        // } else {
        //     GameObject.Find("SetaVerde").SetActive(true);
        // }

        // foreach(GameObject n in pacientes)
        // {
        //     Debug.Log(n.GetComponent<Paciente>().Nome);
        // }
    }

    public void InstanciaPirralho()
    {
        blockInstantiateKid = true;
        GameObject kid = KidInstante.pacientes[Player.day];
        Instantiate(kid, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        //pacientes.RemoveAt(pacientes.Count - 1);
        paciente = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject.GetComponent<Paciente>();
        pacienteObject = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject;
    }

    public void InstanciaPirralhoTeste()
    {
        blockInstantiateKid = false;
        //setaVerde = gameObject;
        Debug.Log("TesteInstanciacao");
    }
}