using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Mesh_yhe : MonoBehaviour

{

    Vector3 V0, V1, V2, V3, V4;

    Vector3[] newVertices;

    int[] newTriangles;



    void Start()

    {

        V0 = new Vector3(-1f, 0, -1f);

        V1 = new Vector3(-1f, 0, 1f);

        V2 = new Vector3(1f, 0, 1f);

        V3 = new Vector3(1f, 0, 1f);

        V4 = new Vector3(0, 2, 0);



        newVertices = new Vector3[]

        {

            V0, V1, V2, V3, V4

        };



        newTriangles = new int[]

        {

            0, 2, 1,

            0, 3, 2,

            0, 4, 3,

            3, 4, 2,

            2, 4, 1,

            1, 4, 0

        };



        gameObject.AddComponent<MeshFilter>();

        gameObject.AddComponent<MeshRenderer>();



        Mesh mesh = new Mesh();

        GetComponent<MeshFilter>().mesh = mesh;

        mesh.vertices = newVertices;

        mesh.triangles = newTriangles;

    }

}