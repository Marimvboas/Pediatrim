using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComparaSintomas : MonoBehaviour
{
    public string palavra1="1", palavra2="2";
    public static bool selecionou = false;
    [SerializeField] private GameObject texto1;
    [SerializeField] private GameObject texto2;

    void Start()
    {
        
    }

    void Update()
    {
        if(selecionou){
            if(palavra1.Equals(palavra2))
            {
                Debug.Log("São iguais");
            }
            else
            {
                //Debug.Log("São diferentes");
            }
        }
        
    }

    // void OnMouseDown(Collider2D other) {
    //     Debug.Log("Mouse");
    //     selecionou = !selecionou;
    //     if(selecionou)
    //     {
    //         texto1 = other.gameObject;
    //         //palavra1 = other.gameObject.GetComponent<Text>().text;
    //         Debug.Log("Escolheu 1");
    //     }
    //     else
    //     {
    //         texto2 = gameObject;
    //         //palavra2 = other.gameObject.GetComponent<Text>().text;
    //         Debug.Log("Escolheu 2");
    //     }
    // }

    public void testeButton()
    {
        selecionou = !selecionou;
        if(selecionou)
        {
            //texto1 = gameObject;
            palavra1 = gameObject.GetComponent<Text>().text;
            Debug.Log("Escolheu 1");
        }
        else
        {
            palavra2 = gameObject.GetComponent<Text>().text;
            Debug.Log("Escolheu 2");
        }
    }
}
