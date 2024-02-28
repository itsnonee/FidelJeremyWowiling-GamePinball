using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    [SerializeField] Collider bola;
    [SerializeField] float length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            CameraController.Instance.FollowTarget(bola.transform, length);
        }
    }
}
