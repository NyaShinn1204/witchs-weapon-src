Shader "Shader Forge/Holographic" {
	Properties {
		_Color ("Color", Vector) = (0.07586192,1,0,1)
		_Light ("Light", 2D) = "white" {}
		_Speed ("Speed", Float) = 0.5
		_BaseTex ("BaseTex", 2D) = "white" {}
		_AlphaOffset ("AlphaOffset", Range(0, 10)) = 1
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ShaderForgeMaterialInspector"
}