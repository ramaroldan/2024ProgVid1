using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3_ActivarHouse : MonoBehaviour
{

    [SerializeField] private GameObject house;


    // Update is called once per frame
    void Update()
    {
        UpdateHouse();
    }

    //Vamos a activar la casa con K y desactivar con J
    private void UpdateHouse()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            activateHouse(isActive: true);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            activateHouse(isActive: false);
        }
    }

    //Activar o desactivar una casa
    private void activateHouse(bool isActive)
    {
        house.SetActive(isActive);
    }
}
