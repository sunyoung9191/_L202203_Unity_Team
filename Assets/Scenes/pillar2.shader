Shader "Custom/pillar2"
{
    Properties
    {
        //_Color ("Color", Color) = (1,1,1,1)
        _MainTex("Albedo (RGB)", 2D) = "white" {}
    //_Glossiness ("Smoothness", Range(0,1)) = 0.5
    //_Metallic ("Metallic", Range(0,1)) = 0.0
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }
        //LOD 200
        cull front

        CGPROGRAM
        #pragma surface surf Nolight vertex:vert noshadow noambient
        // Physically based Standard lighting model, and enable shadows on all light types
        //#pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        //#pragma target 3.0

        //sampler2D _MainTex;

        struct Input
        {
        //float2 uv_MainTex;
        float4 color:COLOR;
    };

    //half _Glossiness;
    //half _Metallic;
    //fixed4 _Color;

    // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
    // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
    // #pragma instancing_options assumeuniformscaling
    //UNITY_INSTANCING_BUFFER_START(Props)
        // put more per-instance properties here
    //UNITY_INSTANCING_BUFFER_END(Props)

    void vert(inout appdata_full v) {
        v.vertex.xyz += v.normal.xyz * 0.05;
    }

    void surf(Input IN, inout SurfaceOutput o)
    {
        // Albedo comes from a texture tinted by color
        //fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
        //o.Albedo = c.rgb;
        // Metallic and smoothness come from slider variables
        //o.Metallic = _Metallic;
        //o.Smoothness = _Glossiness;
        //o.Alpha = c.a;
    }
    float4 LightingNolight(SurfaceOutput s, float3 lightDir, float atten) {
        return float4(0, 0, 0, 1);
    }
    ENDCG

    cull back

    CGPROGRAM
        //#pragma surface surf Lambert
        #pragma surface surf Toon noambient 

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        float4 LightingToon(SurfaceOutput s, float3 lightDir, float atten) {
            float ndotl = dot(s.Normal, lightDir) * 0.5 + 0.5;
            ndotl = ndotl * 5;
            ndotl = ceil(ndotl) / 5;

            return ndotl;
        }
        ENDCG


    }
        FallBack "Diffuse"
}
