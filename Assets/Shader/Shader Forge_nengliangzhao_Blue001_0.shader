Shader "Shader Forge/nengliangzhao_Blue001" {
	Properties {
		_Color_01 ("Color_01", Vector) = (0.4485294,0.7261664,1,1)
		_Color_02 ("Color_02", Vector) = (0.233564,0.5843128,0.9926471,1)
		_Value ("Value", Range(0, 20)) = 1.487179
		_node_2972 ("node_2972", 2D) = "white" {}
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