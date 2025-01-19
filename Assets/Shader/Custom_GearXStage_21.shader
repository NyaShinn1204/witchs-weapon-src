Shader "Custom/GearXStage" {
	Properties {
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_SSSTex ("SSS (RGB)", 2D) = "white" {}
		_ILMTex ("ILM (RGB)", 2D) = "white" {}
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_Outline ("Outline width", Range(0, 2)) = 0.5
		_ShadowContrast ("Vertex Shadow contrast", Range(0, 20)) = 1
		_DarkenInnerLineColor ("Darken Inner Line Color", Range(0, 1)) = 0.2
		_LightDirection ("Light Direction", Vector) = (0,0,1,1)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
}