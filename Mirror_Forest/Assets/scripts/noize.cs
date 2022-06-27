using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noize : MonoBehaviour
{
    // Start is called before the first frame update

    int XPOS;
    int ZPOS;
    public float SPEED;

    void Start()
    {
        //Задаем нашей переменной целочисленное значение
        XPOS = Random.Range(-10000, 10000);
        ZPOS = Random.Range(-10000, 10000);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        //Vector3 destinationPoint = new Vector3(XPOS, 0, ZPOS);
        //перемещаем наш объект к этой точке
       // transform.position = Vector3.Lerp(transform.position, destinationPoint, SPEED * Time.deltaTime);
    }
    float speed = 4;
    Transform target;
    Animator anim;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void FixedUpdate()
    {
        //anim.SetInteger("Enemy", 2);
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            //;

            Debug.Log("1");
            Destroy(gameObject);
            //death.Play();
            // MoveSpaceShip();
            ////if (c == 1)
            //{

            //}

        }
    }
}
