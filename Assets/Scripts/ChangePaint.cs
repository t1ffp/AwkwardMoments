using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangePaint : MonoBehaviour
{
    public Material[] materials;

    private ParticleSystemRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<ParticleSystemRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {

            meshRenderer.material = materials[0];
        }
    }
}
