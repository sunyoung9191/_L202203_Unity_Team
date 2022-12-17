Shader "Custom/Plate"
{
    Properties
    {    
        _MainTex ("Albedo (RGB)", 2D) = "black" {}
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }

        cull front

        CGPROGRAM
        #pragma surface surf Nolight vertex:vert noshadow noambient

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
        
        void vert(inout appdata_full v) {
            v.vertex.xyz += v.normal.xyz * 0.01;
        }

        float4 LightingNolight(SurfaceOutput s, float3 lightDir, float atten) {
            return float4(1, 1, 1, 0);
        }
        ENDCG

        cull back

        CGPROGRAM
        #pragma surface surf Lambert

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

        ENDCG

    }
    FallBack "Diffuse"
}
