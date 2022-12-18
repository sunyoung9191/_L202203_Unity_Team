using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesh_mj : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4;
    Vector3[] newVertices;
    
    Vector3 N0, N1, N2, N3, N4;
    Vector3[] newNormals;

    Vector2 UV0, UV1, UV2, UV3, UV4;
    Vector2[] newUVs;

    int[] newTriangles;

    public Texture newTexture;

    void Start()
    {
        V0 = new Vector3(-0.5f, 1, -2);
        V1 = new Vector3(-0.5f, 1, 0.5f);
        V2 = new Vector3(0.5f, 1, 2);
        V3 = new Vector3(0.5f, 1, -0.5f);
        V4 = new Vector3(0.5f, 2, -0.5f);


        newVertices = new Vector3[]
        {
            V0, V1, V2, V3, V4
        };

        newTriangles = new int[]
        {
            0,2,1,
            0,3,2,
            0,4,3,
            3,4,2,
            2,4,1,
            1,4,0

        };

        N0 = Vector3.left + Vector3.back;
        N1 = Vector3.left + Vector3.forward;
        N2 = Vector3.up;
        N3 = Vector3.right + Vector3.back;
        N4 = Vector3.down;


        newNormals = new Vector3[]
        {
            N0, N1, N2, N3, N4
        };

        UV0 = new Vector2(0, 0.333f);
        UV1 = new Vector2(0, 0.666f);
        UV2 = new Vector2(0.25f, 0.666f);
        UV3 = new Vector2(0.5f, 0.333f);
        UV4 = new Vector2(0.3f, 0.333f);


        newUVs = new Vector2[]
        {
            UV0, UV1, UV2, UV3, UV4
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
        mesh.normals = newNormals;
        mesh.uv = newUVs;

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        DefaultMaterial.mainTexture = newTexture;
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;


    }
}