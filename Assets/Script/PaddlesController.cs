using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlesController : MonoBehaviour
{
    [Header("Paddles Hinge Joint")]
    [SerializeField] private HingeJoint paddleLeft;
    [SerializeField] private HingeJoint paddleRight;
    [Header("Paddles Input")]
    [SerializeField] private KeyCode inputPaddleLeft;
    [SerializeField] private KeyCode inputPaddleRight;

    [SerializeField] private int springPower;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandlePaddleInput(paddleLeft, inputPaddleLeft);
        HandlePaddleInput(paddleRight, inputPaddleRight);
    }

    private void HandlePaddleInput(HingeJoint paddle, KeyCode input)
    {
        if (paddle == null)
        {
            Debug.LogError("Paddle HingeJoint not assigned.");
            return;
        }

        JointSpring spring = paddle.spring;

        if (Input.GetKey(input))
        {
            Debug.Log(paddle.gameObject.name + " Here!");
            spring.spring = springPower;
        }
        else
        {
            spring.spring = 0;
        }

        paddle.spring = spring;
    }
}
