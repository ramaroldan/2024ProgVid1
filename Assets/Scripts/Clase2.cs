using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Clase2 : MonoBehaviour
{
    private bool isAlive; //esta vivo?
    [SerializeField] private int age; //edad
    [SerializeField] private float speed; //velocidad +der -izq
    [SerializeField] private float health; //vida
    [SerializeField] private float maxHealth; //vida maxima
    [SerializeField] private double gravity; //gravedad
    [SerializeField] private string characterName; //nombre personaje
    [SerializeField] private Vector3 initialPosition; //posicion inicial
    [SerializeField] private Vector3 movementDirection; //Direccion en la que se mueva
    [SerializeField] private Vector3 scalingDir; //direccion de escala
    [SerializeField] private float scalingVelociy; //velocidad de escala
    [SerializeField] private Vector3 rotationDir; //direccion de rotacion
    [SerializeField] private float rotationSpeed; //velocidad de rotacion

    [SerializeField] private Bullet bulletPrefab;

    private void Awake()
    {
        Debug.Log(message: "Awake");
        Shoot();
    }

    private void Start()
    {
        Debug.Log(message: "Start");
        Hello();
    }

    private void Update()
    {
        Debug.Log(message: "Update");
        Move();
        CheckDead();
    }

    private void Hello()
    {
        Debug.Log(message:"Hello" + GetInfo());
    }

    private string GetInfo()
    {
        string info;
        info = characterName;
        info += age;
        return info;
    }

    private void ComplexOperation()
    {
        //float complexNumber = ((2 + 5) / 4.5f) * 1.21f;
        int number = 5;
        number += 2;
    }

    //metodo para curar vida
    private void Heal(float healAmount)
    {
        health += healAmount;
        bool hasMaxHealth = health == maxHealth; //igual
        bool hasHealthMissing = health != maxHealth; //distinto
    }

    //metodo para saber si tiene un nombre especial
    private void HasConcreteName()
    {
        bool hasSpecialName = characterName == "Rama";
        bool hasRegularName = characterName != "Rama";
    }

    //si posee cualquiera de esos 2 nombres se le da una habilidad especial
    private void HasSpecialAbility()
    {
        bool hasSpecialName = characterName == "Rama" || characterName == "Na";
        bool hasSpecialAbility = hasSpecialName && isAlive;
    }

    private void CheckDead()
    {
        //chequear si el pj está vivo, tiene mas de 0 de vida /**/
        isAlive = health > 0;
        bool isDead = !isAlive; //cambia el valor del booleano

        //if (isAlive)
        //{
        //    Debug.Log(message:"It´s a alive");
        //}
        //else
        //{
        //    Debug.Log(message: "It´s dead");
        //}

        //Si el personaje esta vivo imprimo "Its a alive"
        //Si el personaje no esta vivo y tiene una velocidad >0, pongo su velocidad en 0
        //si el personaje no esta vivo y su velocidad es =<0, no hago nada
        if (isAlive)
        {
            Debug.Log(message:"It´s a alive");
        }
        else if (speed>0){
            speed = 0;
        }
        else
        {
            Debug.Log(message: "It´s dead");
        }

    }

    //metodo para mover un objeto a una dirección
    private void Move()
    {
        /* //Agarrar la posicion actual del personaje
           Vector3 position = transform.position;
           //Sumarle una cantidad de movimiento
           position = position + movementDirection*speed;
           //Escribir de vuelta la posición
           transform.position = position; 
        */

        //todo en una sola linea
        //transform.position += movementDirection*speed;

        //si esta vivo y la velocidad es mayor a 0
        if (isAlive && speed >0)
        {
            //mover, lotar y escalar
            transform.Translate(movementDirection * speed); //accedemos al transform y movemos el objeto 
            transform.localScale += scalingDir * scalingVelociy;
            transform.Rotate(rotationDir, rotationSpeed);
        }

        //transform.Translate(x:speed, y:0, z:0);
    }

    private void Shoot()
    {
        //hacer aparecer un prefab de bala
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        //moverlo

    }
}

