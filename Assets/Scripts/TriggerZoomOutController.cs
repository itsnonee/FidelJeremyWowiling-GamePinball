using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
    [SerializeField] Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            CameraController.Instance.GoBackToDefault();
        }
    }
}
