using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEmboloSangue : MonoBehaviour
{
    //private Vector2 mousePosition;
    public DistanceJoint2D dist;
    private float deltaDist = 0.001f;

    public GameObject sangueSeringa;
    [SerializeField] private float mlSangue;
    private float mlMax = 2f;
    private bool lockDistance = true;
    private bool finalizou = false;
    public GameObject indicador;

    void Start()
    {
        mlSangue = Random.Range(0.5f, 2f);
        //dist = GameObject.GetComponent<DistanceJoint2D>();
        indicador.transform.position = new Vector2(indicador.transform.position.x+0.7071f*mlSangue, indicador.transform.position.y-0.7071f*mlSangue);
    }

    void Update()
    {
        if (lockDistance)
        {
            dist.enabled = true;
            sangueSeringa.transform.localScale = new Vector2(sangueSeringa.transform.localScale.x, 0f);
        }
        else
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
        if((sangueSeringa.transform.localScale.y<mlSangue+0.1f)&&(sangueSeringa.transform.localScale.y>mlSangue-0.1f))
        {
            finalizou = true;
            Debug.Log("final");
        } 
        else
        {
            lockDistance = true;
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
