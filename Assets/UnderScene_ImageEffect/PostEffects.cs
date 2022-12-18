using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffects : MonoBehaviour
{
    Material myMaterial;
    Shader myShader;

    // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/Invert");
        myMaterial = new Material(myShader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination,myMaterial,0);
    }

    private void OnDisable()
    {   
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
        
    }
}
