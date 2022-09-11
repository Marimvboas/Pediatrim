using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float velocidade = 3f;
    
    void Update()
    {
        Movimentar(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    public void Movimentar(Vector2 direcao)
    {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }
}
