using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat3 : MonoBehaviour
{
    public int get;
    [SerializeField] public GameObject st;
    [SerializeField] public GameObject mark;
    // Start is called before the first frame update
    void Start()
    {
        if (get == 0)
        {
            mark.SetActive(false);
            st.SetActive(true);
            Debug.Log("1");

        }
        else
        {

            mark.SetActive(true);
            st.SetActive(false);
            Debug.Log("1");
        }
        get = PlayerPrefs.GetInt("Save3");
    }
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Save3"))
        {
            PlayerPrefs.SetInt("Save3", 0);
        }
    }
    private bool _insideCollider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            st.SetActive(false);
            mark.SetActive(true);
            Debug.Log("1");
            get = 1;
            PlayerPrefs.SetInt("Save3", get);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
