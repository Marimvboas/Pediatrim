using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportanteLEIA : MonoBehaviour
{
    public static bool jaLeu;
    [SerializeField] List<GameObject> docs = new();

    public void Start()
    {
        jaLeu = false;
        if(jaLeu)
        {
            foreach(GameObject doc in docs)
            {
                doc.SetActive(true);
            }

            gameObject.SetActive(false);
        }
    }
}
