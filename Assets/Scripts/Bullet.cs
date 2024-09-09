using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float movementSpeed; //Velocidad de la bala
    [SerializeField] private float timeToDestroy; //destrucción de la bala

    private void Awake()
    {
        //Le doy X segundos para destruirse la bala
        Destroy(gameObject, timeToDestroy);
    }

    private void Update()
    {
        //Le doy X segundos para destruirse la bala
        //timeToDestroy -= Time.deltaTime;
        //if (timeToDestroy < 0)
        //{
        //    //Destruir la bala
        //    Destroy(gameObject);
        //}

        Move();
    }

    private void Move()
    {
        //forward = adelante del objeto //trnasform.right //transform.up
        transform.position += movementSpeed * transform.forward;
    }
}
