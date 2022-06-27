using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class podskazoxchka : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject menu1;
    public int a = 0;

    public void pod()
    {
        menu1.SetActive(true);
        a = 1;
    }
    public void close() {


        menu1.SetActive(false);
        a = 0;
    }


    // Update is called once per frame
    void Start()
    {
        menu1.SetActive(false);

    }
}
