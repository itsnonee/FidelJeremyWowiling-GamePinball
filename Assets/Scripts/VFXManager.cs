using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public static VFXManager Instance { get; private set; }
    [SerializeField] private GameObject vfxPrefabsBumper;
    [SerializeField] private GameObject vfxPrefabsSwitch;

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

    public void PlayVFXBumper(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxPrefabsBumper, spawnPosition, Quaternion.identity);
    }

    public void PlayVFXSwitch(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxPrefabsSwitch, spawnPosition, Quaternion.identity);
    }
}
