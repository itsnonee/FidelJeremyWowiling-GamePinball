using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpersController : MonoBehaviour
{
    [SerializeField] private Collider ball;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ball)
        {
            Debug.Log("Kena Bola");
        }
    }
}
