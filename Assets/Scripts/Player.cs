using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 3f;
    [SerializeField] bool moveIsBlocked = true, mudancaBlocked;
    [SerializeField] string nomeCena;

    public void Start()
    {
        GameObject foise = GameObject.Find(PlayerPosition.pos);
        StartCoroutine(MoveBlocked());
    }

    public void Update()
    {
        if(gameObject.GetComponent<Player>().moveIsBlocked == false)
            Movement();
        if (Input.GetKeyDown(KeyCode.E) && mudancaBlocked == false)
        {
            PlayerPosition.pos = nomeCena;
            SceneManager.LoadScene(nomeCena);
        }
    }

    public void Movement()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        nomeCena = collision.gameObject.name;
        mudancaBlocked = false;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        mudancaBlocked = true;
    }

    public IEnumerator MoveBlocked()
    {
        yield return new WaitForSeconds(1f);
        moveIsBlocked = false;
    }
=======

public class Player : MonoBehaviour
{
    [SerializeField] Vector2 direction;
    [SerializeField] float speed;

    void Start()
    {
        
    }
    void Update()
    {
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(direction * speed * Time.deltaTime);
    }
>>>>>>> ac78bc52eedc678ad8f4491a3484b55b0e8c70a9
}
