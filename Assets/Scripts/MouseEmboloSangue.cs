using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEmboloSangue : MonoBehaviour
{
    //private Vector2 mousePosition;
    public DistanceJoint2D dist;
    private float deltaDist = 0.001f;
    [SerializeField] GameObject congratulationButton, barraConfianca, posBarra, buttonGameOver;
    public AudioSource aud;
    public GameObject sangueSeringa;
    [SerializeField] private float mlSangue;
    private float mlMax = 1f;
    private bool lockDistance = true;
    public static bool finalizou = false;
    public GameObject indicador;
    public Collider2D coll;

    void Start()
    {
        buttonGameOver.SetActive(false);
        mlSangue = Random.Range(0.25f, 1f);
        //dist = GameObject.GetComponent<DistanceJoint2D>();
        barraConfianca.transform.localScale = new Vector3(Player.pontoConfianca, 1f, 1f);
        barraConfianca.transform.position = posBarra.transform.position;
        coll.enabled = true;
        indicador.transform.position = new Vector2(indicador.transform.position.x+(0.7071f*mlSangue*2), indicador.transform.position.y-(0.7071f*mlSangue*2));
    }

    void Update()
    {
        if(Player.pontoConfianca==0){
            buttonGameOver.SetActive(true);
            coll.enabled = false;
        } else if (lockDistance)
        {
            dist.enabled = true;
            sangueSeringa.transform.localScale = new Vector2(sangueSeringa.transform.localScale.x, 0f);    
        } else
        {
            dist.enabled = false;

        }
    }

    private void OnMouseDown()
    {
        lockDistance = false;
    }

    private void OnMouseUp()
    {
        if((sangueSeringa.transform.localScale.y<mlSangue+0.04f)&&(sangueSeringa.transform.localScale.y>mlSangue-0.04f))
        {
            finalizou = true;
            congratulationButton.SetActive(true);
            Debug.Log("final");
        } 
        else
        {
            lockDistance = true;
            Player.pontoConfianca -= 0.25f;
            aud.Play();
            barraConfianca.transform.localScale = new Vector3(Player.pontoConfianca, 1f, 1f);
            barraConfianca.transform.position = posBarra.transform.position;
        }        
    }
 
    private void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            if(sangueSeringa.transform.localScale.y < mlMax)
            {
                transform.position = new Vector2(transform.position.x + deltaDist, transform.position.y - deltaDist);
                //Debug.Log("move");
                sangueSeringa.transform.localScale = new Vector2(sangueSeringa.transform.localScale.x, sangueSeringa.transform.localScale.y+deltaDist);
            }

        }
    }
}
