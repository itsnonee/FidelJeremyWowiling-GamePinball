using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;

    private bool isOn;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Debug.Log("Bola kena switch");
            Set(!isOn);
        }
    }

    void Set(bool active)
    {
        isOn = active;
        renderer.material = isOn ? onMaterial : offMaterial;
    }
}
