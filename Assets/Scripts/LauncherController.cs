using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    [SerializeField] private Collider bola;
    [SerializeField] private KeyCode input;
    [SerializeField] private float maxForce;
    [SerializeField] private float maxTimeHold;
    private Renderer renderer;
    [SerializeField] private Color colorHold;
    [SerializeField] private Color colorDefault;

    private bool isHold = false;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            Debug.Log("Bola dah stay");
            ReadInput(bola);
        }
    }

    void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
            renderer.material.color = colorHold;
        }
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        renderer.material.color = colorDefault;
        
    }
}
