using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;
using TMPro;

using UnityEngine.Video;


public class final : MonoBehaviour
{
    [SerializeField] GameObject gate;
    [SerializeField] GameObject vid;
    [SerializeField] AudioSource death;
    [SerializeField] AudioSource bell;
    [SerializeField] int speed;
    [SerializeField] public int n_scene;
    [SerializeField] int abs = 0;

    Animator anim;
    private VideoPlayer MyVideoPlayer;

  
       

        void Start()
    {
            vid.SetActive(false);
        
        gameObject.transform.position = new Vector2(PlayerPrefs.GetFloat("Xpos"), PlayerPrefs.GetFloat("Ypos"));
        // arts.SetActive(false);
        // d1.gameObject.SetActive(false);
        anim.SetInteger("Aspen", 2);
    }
    void Update()
    {

       
        // Lever();
        Move();
        ABS();
        //Health();
        //anim.SetInteger("Aspen", 2);



    }
    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>(); // Активация анимации
    
    }

    public void activ()
    {
        
       

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


    private bool _insideCollider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("1");
            ////if (c == 1)
            //{
            SceneManager.LoadScene(n_scene);
            //vid.SetActive(true);
            //MyVideoPlayer = GetComponent<VideoPlayer>();
            // play video player
            //MyVideoPlayer.Play();
            //}

        }
    }


    

}
