Shader "Shader Forge/Bianyuanguang02_Yellow01" {
	Properties {
		_node_2701 ("node_2701", 2D) = "white" {}
		_node_9431 ("node_9431", 2D) = "white" {}
		_node_6379 ("node_6379", 2D) = "white" {}
		_node_8248 ("node_8248", 2D) = "white" {}
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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
	//CustomEditor "ShaderForgeMaterialInspector"
}