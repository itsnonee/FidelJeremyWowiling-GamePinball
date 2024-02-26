using UnityEngine;

public class BumpersController : MonoBehaviour
{
    [SerializeField] private Collider ball;
    [SerializeField] private float multiplier;
    [SerializeField] private Color color;
    [SerializeField] private Renderer renderer;
    [SerializeField] private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == ball)
        {
            Rigidbody rigBall = ball.GetComponent<Rigidbody>();
            rigBall.velocity *= multiplier;

            //animasi
            animator.SetTrigger("Hit");
        }
    }
}
