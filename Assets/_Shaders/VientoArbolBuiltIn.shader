Shader "Custom/VientoArbolBuiltIn"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB) Alpha (A)", 2D) = "white" {}
        _Cutoff ("Alpha Cutoff", Range(0,1)) = 0.4
        _WindSpeed ("Velocidad Viento", Float) = 1.6
        _WindStrength ("Fuerza Viento", Float) = 0.12
    }
    SubShader
    {
        Tags { "Queue"="AlphaTest" "IgnoreProjector"="True" "RenderType"="TransparentCutout" }
        LOD 200
        Cull Off

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows alphatest:_Cutoff vertex:vert addshadow

        sampler2D _MainTex;
        fixed4 _Color;
        float _WindSpeed;
        float _WindStrength;

        struct Input
        {
            float2 uv_MainTex;
        };

        void vert(inout appdata_full v)
        {
            // Ancla la base del tronco (Y <= 0.2) y balancea la copa suavemente
            float altura = saturate((v.vertex.y - 0.2) * 0.5);
            float fase = v.vertex.x * 1.7 + v.vertex.z * 1.7;
            float ondaX = sin(_Time.y * _WindSpeed + fase);
            float ondaZ = cos(_Time.y * (_WindSpeed * 0.85) + fase);
            v.vertex.x += ondaX * _WindStrength * altura;
            v.vertex.z += ondaZ * (_WindStrength * 0.6) * altura;
        }

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 tex = tex2D(_MainTex, IN.uv_MainTex);
            fixed4 c = tex * _Color;
            o.Albedo = c.rgb;
            o.Metallic = 0.0;
            o.Smoothness = 0.0;
            o.Alpha = tex.a;
        }
        ENDCG
    }
    FallBack "Transparent/Cutout/VertexLit"
}
