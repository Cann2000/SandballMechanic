using UnityEngine;

public class PlaneDeformer : MonoBehaviour
{
    //public references
    public float radiusOfDeformation;
    public float powerOfDeformation;
    public GameObject cylinderPrefab;


    // private references
    MeshFilter meshFilter;
    Mesh mesh;
    MeshCollider col;
    Vector3[] verts;

    private void Awake()
    {
        meshFilter = GetComponent<MeshFilter>();
        col = GetComponent<MeshCollider>();
        mesh = meshFilter.mesh;
        verts = mesh.vertices;
    }

    public void deformThePlane(Vector3 positionToDeform)
    {
        positionToDeform = transform.InverseTransformPoint(positionToDeform);
        bool somethingDeformed = false;

        for (int i = 0; i < verts.Length; i++)
        {
            float dist = (verts[i] - positionToDeform).sqrMagnitude;

            if (dist < radiusOfDeformation)
            {
                verts[i] -= Vector3.up * powerOfDeformation;
                somethingDeformed = true;
            }

        }
        if (somethingDeformed)
        {
            mesh.vertices = verts;
            col.sharedMesh = mesh;
        }
    }

    public void puthole(Vector3 positionToDeform, float radius)
    {
        positionToDeform = transform.InverseTransformPoint(positionToDeform);
        bool somethingDeformed = false;

        for (int i = 0; i < verts.Length; i++)
        {
            float dist = (verts[i] - positionToDeform).sqrMagnitude;

            if (dist < radius)
            {
                verts[i] -= Vector3.up * powerOfDeformation;
                somethingDeformed = true;
            }

        }
        if (somethingDeformed)
        {
            mesh.vertices = verts;
            col.sharedMesh = mesh;
        }
    }
}
