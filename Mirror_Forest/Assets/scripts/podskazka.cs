using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class podskazka : MonoBehaviour
{
    [SerializeField] GameObject menu1;
    public int a1;
    // Start is called before the first frame update
    public void a ()
    { 
    if (a1 == 1)
        {
            menu1.SetActive(true);
            a1 = 0;

        }
    }
    public void close()
    {

        menu1.SetActive(false);

    }
}
