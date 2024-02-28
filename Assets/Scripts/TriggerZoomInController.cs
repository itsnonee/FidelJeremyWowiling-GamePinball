using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            
        }
    }
}
