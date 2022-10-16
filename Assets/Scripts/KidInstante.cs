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

    // public KidInstante(){

    // }
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
    }

    void Start()
    { 
        // if(pacientes == null && Player.day == 0)
        // {   
        //     KidInstante.pacientes = new List<GameObject>();

        //     KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Gustavo"));
        //     KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Joao"));
        //     KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Luana da Silva"));
        //     KidInstante.pacientes.Add(Resources.Load<GameObject>("Prefabs/Maria Eduarda"));

        //     InstanciaPirralho();
        // }

        // if (KidInstante.paciente != null)
        // {
        //     Debug.Log("entrou na paciente != null");
        //     Instantiate(KidInstante.paciente.gameObject, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        // }

        // if(!pacienteObject.transform.IsChildOf(gameObject.transform))
        // {
        //     Instantiate(KidInstante.paciente.gameObject, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        // }
        if(paciente == null && !blockInstantiateKid)
        {
            InstanciaPirralho();
        }
        // foreach(GameObject n in pacientes)
        // {
        //     Debug.Log(n.GetComponent<Paciente>().Nome);
        // }
    }

    // public void InstanciaPirralho()
    // {
    //     blockInstantiateKid = true;
    //     GameObject kid = KidInstante.pacientes[pacientes.Count - 1];
    //     Instantiate(kid, gameObject.transform.position, Quaternion.identity, gameObject.transform);
    //     pacientes.RemoveAt(pacientes.Count - 1);
    //     paciente = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject.GetComponent<Paciente>();
    //     pacienteObject = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject;
    // }

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
        // GameObject kid = KidInstante.pacientes[pacientes.Count - 1];
        // Instantiate(kid, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        // pacientes.RemoveAt(pacientes.Count - 1);
        // paciente = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject.GetComponent<Paciente>();
        // pacienteObject = GameObject.Find("KidInstantiate").transform.GetChild(0).gameObject;
        //Destroy(gameObject);
        Debug.Log("TesteInstanciacao");
    }
}