using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;
using TMPro;

public class tet : MonoBehaviour
{
    [SerializeField] AudioSource death;
    [SerializeField] AudioSource bell;
    [SerializeField] int speed;
    [SerializeField] public int n_scene;
    //[SerializeField] GameObject arts;
    [SerializeField] GameObject st1;
    [SerializeField] GameObject st2;
    [SerializeField] GameObject st3;
    [SerializeField] GameObject st4;
    [SerializeField] GameObject gate;
    [SerializeField] GameObject enemy;
    // [SerializeField] TMP_Text lever;
    //[SerializeField] TMP_Text hp;

    public int a = 0;
    public int b = 0;
    public int c = 0;
    public int art = 0;
    [SerializeField ]int abs = 0;
    public int health = 1;
    //string h = " ";

    private Vector3 en1 = new Vector3(-38, 126, 3);
    private Vector3 en2 = new Vector3(-128, -42, 3);
    private Vector3 en3 = new Vector3(340, 207, 3);
    private Vector3 en4 = new Vector3(162, 49, 3);
    private Vector3 en5 = new Vector3(0, 38, 3);


    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //enemy= GameObject.FindGameObjectsWithTag("Enemy");
        activ();
        gameObject.transform.position = new Vector2 (PlayerPrefs.GetFloat("Xpos"), PlayerPrefs.GetFloat("Ypos"));
       // arts.SetActive(false);
        // d1.gameObject.SetActive(false);
        anim.SetInteger("Aspen", 2);
    }
    void Update()
    {
        
        final();
       // Lever();
        Move();
        ABS();
        //Health();
        //anim.SetInteger("Aspen", 2);



    }
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>(); // Активация анимации
        if (!PlayerPrefs.HasKey("Xpos"))
        {
            PlayerPrefs.SetFloat("Xpos", 0);
        }
        if (!PlayerPrefs.HasKey("Ypos"))
        {
            PlayerPrefs.SetFloat("Ypos", 0);
        }
    }
   
    public void activ()
    {
        st1.SetActive(false);
        st2.SetActive(false);
        st3.SetActive(false);
        st4.SetActive(false);
        gate.SetActive(false);

    }
    public void final()
    {
        if (art == 4)
        {
            bell.Play();
            Debug.Log("aaa");
            gate.SetActive(true);
        }
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            abs = 1;
            transform.position += transform.up * speed * Time.deltaTime;
            anim.SetInteger("Aspen", 4);
        }



        if (Input.GetKey(KeyCode.S))
        {
            abs = 1;
            transform.position -= transform.up * speed * Time.deltaTime;
            //anim.SetInteger("Stay", 4);
            anim.SetInteger("Aspen", 3);
        }



        if (Input.GetKey(KeyCode.D))
        {
            abs = 1;
            transform.position += transform.right * speed * Time.deltaTime;
            //anim.SetInteger("Stay", 1);
            anim.SetInteger("Aspen", 1);
        }



        if (Input.GetKey(KeyCode.A))
        {
            abs = 1;
            transform.position -= transform.right * speed * Time.deltaTime;
            //anim.SetInteger("Stay", 2);
            anim.SetInteger("Aspen", 6);
        }
    }
    void ABS()
    {
        if (abs == 1)
        {
            anim.SetInteger("Aspen", 2);
            Move();
        }
    }







    //Коллайдер


    private bool _insideCollider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("1");
            ////if (c == 1)
            //{
                SceneManager.LoadScene(n_scene);
            //}

        }
        if (other.tag == "statu")
        {
            Debug.Log("2");
            ////if (c == 1)
            //{
            st1.SetActive(true);
            art = art+1;
            enemy.transform.position = en1;
           // arts.SetActive(true);

            //}

           }
        if (other.tag == "statu2")
        {
            Debug.Log("2");
            ////if (c == 1)
            //{
            st2.SetActive(true);
            art = art + 1;
            enemy.transform.position = en2;
            // arts.SetActive(true);

            //}

        }
        if (other.tag == "statu3")
        {
            Debug.Log("2");
            ////if (c == 1)
            //{
            st3.SetActive(true);
            art = art + 1;
            enemy.transform.position = en3;
            // arts.SetActive(true);

            //}

        }
        if (other.tag == "statu4")
        {
            Debug.Log("2");
            ////if (c == 1)
            //{
            st4.SetActive(true);
            art = art + 1;
            enemy.transform.position = en4;

        }

        if (other.tag == "Enemy")
        {
            Debug.Log("3");
            death.Play();
            Debug.Log("-1");
            health = health - 1;
            gameObject.transform.position = new Vector2(PlayerPrefs.GetFloat("Xpos"), PlayerPrefs.GetFloat("Ypos"));
            enemy.transform.position = en5;
           // SceneManager.LoadScene("1");


        }





    }

    void deth()
    {

        if (health == 0)
        {
            gameObject.transform.position = new Vector2(PlayerPrefs.GetFloat("Xpos"), PlayerPrefs.GetFloat("Ypos"));
            enemy.transform.position = en5;

        }

    }



   

    public void save()
    {
        PlayerPrefs.SetFloat("Xpos",gameObject.transform.position.x);
        PlayerPrefs.SetFloat("Ypos", gameObject.transform.position.y);

    }
}
    
