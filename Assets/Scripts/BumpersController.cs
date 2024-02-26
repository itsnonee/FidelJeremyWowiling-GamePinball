using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpersController : MonoBehaviour
{
    [SerializeField] private Collider ball;
    [SerializeField] private float multiplier;
    [SerializeField] private Color color;

    private void Start()
    {
        GetComponent<Renderer>().material.color = color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ball)
        {
            Rigidbody rigBall = ball.GetComponent<Rigidbody>();
            rigBall.velocity *= multiplier;
        }
    }
}
