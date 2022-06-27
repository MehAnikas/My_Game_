using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class menu : MonoBehaviour
{
    [SerializeField] GameObject menu1;
    public int a = 0;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        menu1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (a == 0)
            {
                menu1.SetActive(true);
                a = 1;
                Time.timeScale = 0;
                isPaused = true;
            }
            else {

                menu1.SetActive(false);
                a = 0;
                Time.timeScale = 1;
                isPaused = false;
            }
           
        }
    }
}
