using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            transform.position += movementSpeed * transform.forward;
        }

    }
}


