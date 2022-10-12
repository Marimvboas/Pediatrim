using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidInstante : MonoBehaviour
{
    public static Paciente paciente;
    public static KidInstante Instance;
    [SerializeField] List<GameObject> pacientes = new();
    void Start()
    { 
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);

    }

    public void InstanciaPirralho()
    {
        int i = Random.Range(0, pacientes.Count);
        Instantiate(pacientes[i], gameObject.transform.position, Quaternion.identity, gameObject.transform);
        pacientes.RemoveAt(i);
        paciente = GameObject.Find("KidInstantiate").transform.GetChild(0).GetComponent<Paciente>();
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);

    }

}
