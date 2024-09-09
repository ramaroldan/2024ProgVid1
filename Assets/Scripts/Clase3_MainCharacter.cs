using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3_MainCharacter : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    [SerializeField] private Bullet bullet;
    [SerializeField] private float shootingCooldownBase; //Tiempo de espera por disparo

    private float shootingCooldown; //Temporizador de disparo


    private void Awake()
    {
        shootingCooldown = shootingCooldownBase;
    }

    // Update is called once per frame
    void Update()
    {

        //Mover utilizando WASD

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movementDir = new Vector2 (horizontal, vertical);

        //Vector2 movementDir = new Vector2();
        //if (Input.GetKey(KeyCode.W))
        //{
        //    movementDir.y += 1;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    movementDir.x -= 1;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    movementDir.y -= 1;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    movementDir.x += 1;
        //}

        //Si el jugador presiono Space y el cooldown ya se termino, dispara
        shootingCooldown -= Time.deltaTime;
        if (Input.GetButton("Shoot") && shootingCooldown<=0)
        {
            shootingCooldown = shootingCooldownBase;
            Shoot();
        }

        movementDir = movementDir.normalized;
        Move(movementDir);

    }

    private void Shoot()
    {
        //Disparo
        Instantiate(bullet, transform.position, transform.rotation);
    }

    private void Move(Vector2 movementDir)
    {
        //Matematica vectorial
        //convertimos eje Y en eje Z para poder movernos adelante y atras y no subir o bajar
        //Vector3 movement = new Vector3 (movementDir.x, y:0, z:movementDir.y);

        //Para que el PJ se mueve en torno a su propio EJE
        //Agarro el vector derecha del jugador y lo multiplico por X
        Vector3 right = transform.right * movementDir.x;
        //Agarro el vector adelante del jugador y lo multiplico por y
        Vector3 forward = transform.forward * movementDir.y;
        //Sumo ambos vectores
        Vector3 direction = right + forward;

        transform.position += direction * movementSpeed * Time.deltaTime;
    }

}
