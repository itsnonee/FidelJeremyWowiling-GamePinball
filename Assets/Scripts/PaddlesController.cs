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

    [Header("Target Position")]
    private float targetPressed;
    private float targetReleased;

    // Start is called before the first frame update
    void Start()
    {
        hingeLimits();
    }

    // Update is called once per frame
    void Update()
    {
        HandlePaddleInput(paddleLeft, inputPaddleLeft);
        HandlePaddleInput(paddleRight, inputPaddleRight);
    }

    private void hingeLimits()
    {
        hingeLimitsMinMaxPaddles(paddleLeft);
        hingeLimitsMinMaxPaddles(paddleRight);
    }

    private void hingeLimitsMinMaxPaddles(HingeJoint hingeJoint)
    {
        targetReleased = hingeJoint.limits.min;
        targetPressed = hingeJoint.limits.max;
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
            spring.targetPosition = targetPressed;
        }
        else
        {
            spring.targetPosition = targetReleased;
        }

        paddle.spring = spring;
    }
}
