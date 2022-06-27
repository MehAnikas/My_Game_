using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    [SerializeField] AudioSource death;
    [SerializeField] AudioSource gotit;
    public float a = 10;
   // [SerializeField] GameObject player;
   // public Transform enemy;
    //float dist = Vector3.Distance(player.position, gameObject.position);
    private Vector3 pos = new Vector3(1, 1, 1);
    private Vector3 dist = new Vector3(1, 1, 1);
   // float dist = new Vector3(1,1,1);
    //float dist = Vector3.Distance(player.position, transform.position);

    void OnTriggerEnter2D(Collider2D other)
    
    {
      
        if (other.tag == "Light")
        {
            //;

            Debug.Log("1");
            //Destroy(gameObject, 5);
            //death.Play();
            gameObject.transform.position=pos;
            //Vector3 newSpawnPosition = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
            // MoveSpaceShip();
            ////if (c == 1)
            //{
            connect();

            //}

        }

        if (other.tag == "Player")
        {
            //;

            Debug.Log("1");
            //Destroy(gameObject, 5);
            gotit.Play();
            
            // MoveSpaceShip();
            ////if (c == 1)
            //{

            //}

        }

    }
    public void connect()
    {
       // a = (float)dist;
        //if (dist < 10)    //вместо if/else можно использовать более сокращенную запись: light.enabled = dist <= 10;
        //{
            
            death.Play();
        //}
        
    }
    private void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        Debug.Log(dist);

        
    }


    //Transform target;
    //Animator anim;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    anim.SetInteger("Enemy", 1);
    //    target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
    //    anim.SetInteger("Enemy", 1);
    //    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    //}
    float speed = 6;
    public Transform target;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(repeat, 0, 5);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // dist = Vector3.Distance(target.position, transform.position);
        float dist = Vector3.Distance(target.position, transform.position);
        //Debug.Log(dist);
        //anim.SetInteger("Enemy", 2);
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }
}
