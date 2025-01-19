Shader "Shader Forge/Bianyuanguang01" {
	Properties {
		_node_2744 ("node_2744", 2D) = "white" {}
		_node_3491 ("node_3491", 2D) = "white" {}
		_node_6648 ("node_6648", 2D) = "white" {}
		_node_577 ("node_577", 2D) = "white" {}
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