using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] public int n_scene;
   
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(n_scene);
    }
}
