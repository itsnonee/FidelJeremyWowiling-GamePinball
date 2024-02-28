using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public static VFXManager Instance { get; private set; }
    [SerializeField] private GameObject vfxPrefabs;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxPrefabs, spawnPosition, Quaternion.identity);
    }
}
