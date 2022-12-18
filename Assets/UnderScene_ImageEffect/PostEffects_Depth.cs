using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffects_Depth : MonoBehaviour
{
    Material myMaterial;
    Shader myShader;
    
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/Depth");
        myMaterial = new Material(myShader);
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }

    }
}
