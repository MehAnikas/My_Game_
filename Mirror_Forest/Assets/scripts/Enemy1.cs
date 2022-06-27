using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    //public GameObject cubik;

    //void Start()
    //{
    //    StartCoroutine(Spawn());
    //}

    //IEnumerator Spawn()
    //{

    //        Instantiate(cubik, new Vector2(Random.Range(-8f, 8f),-3), Quaternion.identity);
    //        yield return new WaitForSeconds(1f);

    //}

    [SerializeField] private GameObject[] _Fruit;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _spawnDelay;
    GameObject b;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update() {
    
    
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnDelay);

            int randomFruit = Random.Range(0, _Fruit.Length);
            int randomSpawnPoint = Random.Range(0, _spawnPoints.Length);

            b=Instantiate(_Fruit[randomFruit], _spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
    public void OnBecameInvisible()
    {

        Destroy(b);

    }
   
}
