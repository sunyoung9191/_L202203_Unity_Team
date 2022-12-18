using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh_ohe : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newVertices;
    int[] newTriangles;


    void Start()
    {
        V0 = new Vector3(0, 0, 0);
        V1 = new Vector3(3, 0, 0);
        V2 = new Vector3(3, 3, 0);
        V3 = new Vector3(0, 3, 0);
        V4 = new Vector3(1, 2, 5);
        V5 = new Vector3(1, 1, 5);
        V6 = new Vector3(2, 1, 5);
        V7 = new Vector3(2, 2, 5);


        newVertices = new Vector3[]
        {
            V0, V1, V2, V3, V4, V5,V6,V7
        };

        newTriangles = new int[]
        {
            1,3,0,
            1,2,3,
            3,4,5,
            3,5,0,
            0,5,1,
            1,5,6,
            6,7,1,
            1,7,2,
            2,7,3,
            3,7,4,
            4,6,5,
            4,7,6


            
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}
