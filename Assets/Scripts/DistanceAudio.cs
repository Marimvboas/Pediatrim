using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAudio : MonoBehaviour
{
    [SerializeField] GameObject estetos, heart, congratulationButton;
    Vector3 distance;

    bool onHeart;
    public float distancia;
    public AudioSource aud;
    float initialTime = 999999999f;
    float tempoAtual = 0;
    public static bool terminouExame = false;

    void Update()
    {
        distancia = Vector3.Distance(estetos.transform.position, heart.transform.position);

        if (distancia <= 2)
        {

            if (distancia < 1.01f && distancia > 0.8f)
            {
                initialTime = Time.time;
                Debug.Log("inicial: " + initialTime);
            }
            if(distancia < 0.8f)
            {
                tempoAtual = Time.time;
                Debug.Log("Atual: " + tempoAtual);
            }
            if ((tempoAtual - initialTime) >= 2f)
            {
                congratulationButton.SetActive(true);
                heart.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                Debug.Log("Entrou ultimo if");
                terminouExame = true;
            }

            aud.volume = 1-(distancia/2);
        }
        else
        {
            aud.volume = 0;
            initialTime = 999999999f;
        }        
    }
}
