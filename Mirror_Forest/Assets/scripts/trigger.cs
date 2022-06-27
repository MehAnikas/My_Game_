using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    [SerializeField] GameObject dia;
    // Start is called before the first frame update
    void Start()
    {
        dia.SetActive(false);

    }
    private bool _insideCollider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            dia.SetActive(true);
            Debug.Log("1");
        }
        else
        {
           dia.SetActive(false);
            Debug.Log("2");
        }

    }
}