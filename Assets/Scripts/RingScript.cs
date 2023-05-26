using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{
    [SerializeField] MeshCollider[] Colliders;

    private void Start()
    {
        foreach (var item in Colliders)
        {
            item.enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RingBlock"))
        {
            Destroy(other.gameObject);
        }
    }
}
