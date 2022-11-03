using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static int day = 0;
    public static string pos = "posInitial";
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 3f;
    [SerializeField] bool moveIsBlocked = true, mudancaBlocked;
    //public static string nomeCena ="SalaDeEspera";
    [SerializeField] string nomeCena;
    [SerializeField] Animator anim;
    [SerializeField] SpriteRenderer sp;
    [SerializeField] GameObject botaoE;
    //public static int countFinalizouExame = 0;
    public static int count = 0; //contador da quantidade de sintomas linkados corretamente
    public static float pontoConfianca = 1f; //ponto de confiança

    public void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
        GameObject foise = GameObject.Find(Player.pos);
        transform.position = foise.gameObject.transform.position;
        StartCoroutine(MoveBlocked());
        botaoE = gameObject.transform.GetChild(0).gameObject;
    }

    public void Update()
    {
        if (gameObject.GetComponent<Player>().moveIsBlocked == false)
            Movement();
        if (Input.GetKeyDown(KeyCode.E) && mudancaBlocked == false)
        {
            //day = 4;
            Player.pos = nomeCena;
            if(nomeCena != "CasaDialogo")
                SceneManager.LoadScene(nomeCena);
            if (nomeCena.Equals("Casa"))
            {
                KidInstante.paciente = null;
                KidInstante.kid=null;
                Debug.Log("kid: "+KidInstante.kid);
                Debug.Log(Player.count);

                if ((Player.count == 3))
                {
                    Player.day += 1;
                    Player.count = 0;
                    DialogoPaciente.blockFala = false;
                    //Player.countFinalizouExame = 0;
                    Debug.Log("Day:" + Player.day);
                }
            }
            if (Player.day == 4 && nomeCena.Equals("CasaDialogo"))
            {
                
                GameObject temp = GameObject.Find("Dialogo");
                temp.GetComponent<DialogoCasa>().activecontrol = true;
                temp.GetComponent<DialogoCasa>().digite = true;
            }
        }

    }

    public void Movement()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        anim.SetFloat("Horizontal", direction.x);
        if (direction.x < 0)
            sp.flipX = true;
        else if (direction.x > 0)
            sp.flipX = false;
        anim.SetFloat("Vertical", direction.y);
        anim.SetFloat("Speed", direction.magnitude);

        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        nomeCena = collision.gameObject.name;
        botaoE.SetActive(true);
        mudancaBlocked = false;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        botaoE.SetActive(false);
        mudancaBlocked = true;
    }

    public IEnumerator MoveBlocked()
    {
        yield return new WaitForSeconds(1f);
        moveIsBlocked = false;
    }
}
