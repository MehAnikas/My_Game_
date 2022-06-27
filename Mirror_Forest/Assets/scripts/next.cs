using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    [SerializeField] public int n_scene;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("YourCoroutine");
    }

    IEnumerator YourCoroutine()
    {
        yield return new WaitForSeconds(12f);
        Debug.Log("Прошло пол секунды");
        SceneManager.LoadScene(n_scene);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
