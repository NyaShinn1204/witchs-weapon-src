Shader "Avalon2/Model/whater_shen" {
	Properties {
		_WaterTex ("Normal Map (RGB), Foam (A)", 2D) = "white" {}
		_AlphaTex ("AlphaTex", 2D) = "black" {}
		_shadowLight ("shadowLight", Range(0, 1)) = 0
		_Tiling ("Wave Scale", Range(0.25, 0.007)) = 0.25
		_WaveSpeed ("Wave Speed", Float) = 0.4
		_SpecularRatio ("Specular Ratio", Range(10, 500)) = 200
		_outSideColor ("outSideColor", Vector) = (0,0,0,0)
		_outSideLight ("outSideLight", Range(0, 10)) = 1
		_inSideColor ("inSideColor", Vector) = (0,0,0,0)
		_inSideLight ("intSideLight", Range(0, 10)) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		_LightColorSelf ("LightColorSelf", Vector) = (1,1,1,1)
		_LightDir ("LightDir", Vector) = (0,1,0,0)
		_specularLight ("specularLight", Range(0.1, 2)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
}