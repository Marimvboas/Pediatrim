using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImportanteLEIA : MonoBehaviour
{
    public static bool jaLeu;
    [SerializeField] List<GameObject> docs = new();

    public void Start()
    {
        if (!ImportanteLEIA.jaLeu)
        {
            foreach (GameObject doc in docs)
            {
                doc.GetComponent<Button>().enabled = false;
            }
        }

        if(ImportanteLEIA.jaLeu)
        {
            foreach(GameObject doc in docs)
            {
                doc.SetActive(true);
            }

            gameObject.SetActive(false);
        }
    }

    public void Update()
    {
        if (ImportanteLEIA.jaLeu)
        {
            foreach (GameObject doc in docs)
            {
                doc.GetComponent<Button>().enabled = true;
            }

            gameObject.SetActive(false);
        }
    }

    public void JaLi()
    {
        jaLeu = true;
    }
}
