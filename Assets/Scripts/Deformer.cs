using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deformer : MonoBehaviour
{
    public PlaneDeformer planedeform;

    void Start()
    {
        planedeform.deformThePlane(transform.position);
    }

}
