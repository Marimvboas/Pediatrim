using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChamaKid : MonoBehaviour
{
    [SerializeField] GameObject kidinstance;
    public void Start()
    {
        
    }

    public void OnGreenArrowClick()
    {

        if(KidInstante.Instance.transform.GetChild(0))
        {
            Destroy(KidInstante.Instance.transform.GetChild(0).gameObject);
        }
        KidInstante.Instance.InstanciaPirralho();

    }
}
