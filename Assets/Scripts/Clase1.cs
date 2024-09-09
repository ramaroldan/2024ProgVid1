using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase1_Script : MonoBehaviour
{
    //Variables (informacion)
    [SerializeField] private bool isDead; //Murio?
    [SerializeField] private float speed; //velocidad
    [SerializeField] private int age; //anios
    [SerializeField] private double gravity; //gravedad
    [SerializeField] private string characterName; //Nombre del personaje
    [SerializeField] private Vector3 initialPosition; //posicíon inicial

    //Llamar a los metodos y codigos
    private void Start()
    {
        Hello();
    }

    //Metodos (capacidad, funcion)
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

}


