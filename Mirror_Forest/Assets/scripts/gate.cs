using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    public int speed;
    [SerializeField] float minX = -8.0f;
    [SerializeField] float maxX = 8.0f;
    [SerializeField] float minY = 1.0f;
    [SerializeField] float maxY = -3.0f;


    void Update()
    {


        transform.position = new Vector3(Mathf.Clamp(transform.position.x + Time.deltaTime * speed, minX, maxX),

                                 Mathf.Clamp(transform.position.y + Time.deltaTime * speed, minY, maxY),
                                 transform.position.z);

    }
}
