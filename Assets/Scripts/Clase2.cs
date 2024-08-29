using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Clase2 : MonoBehaviour
{
    [SerializeField] private bool isAlive;
    [SerializeField] private int age;
    [SerializeField] private float speed;
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    [SerializeField] private double gravity;
    [SerializeField] private string characterName;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private Vector3 movementDirection;
    [SerializeField] private Vector3 scalingDir;
    [SerializeField] private float scalingVelociy;
    [SerializeField] private Vector3 rotationDir;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private Bullet;

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
    }

    private void Hello()
    {
        Debug.Log("Hello" + GetInfo());
    }

    private string GetInfo()
    {
        string info;
        info = characterName;
        info = info + age;
        return info;
    }

    private void ComplexOperation()
    {
        float complexNumber = ((2 + 5) / 4.5f) * 1.21f;
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
        //chequear si el pj está vivo /**/
        isAlive = health > 0;
        bool isDead = !isAlive; //cambia el valor del booleano
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
        transform.position += movementDirection*speed;

        //mover, lotar y escalar
        transform.Translate(x:speed, y:0, z:0);
        transform.localScale += scalingDir * scalingVelociy;
        transform.Rotate(rotationDir, rotationSpeed);
    }

    private void Shoot()
    {
        //hacer aparecer un prefab de bala
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        //moverlo

    }
}

