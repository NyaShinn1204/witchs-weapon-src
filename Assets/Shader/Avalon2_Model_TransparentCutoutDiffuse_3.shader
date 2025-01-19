Shader "Avalon2/Model/TransparentCutoutDiffuse" {
	Properties {
		_MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
		_EffectAmount ("Effect Amount", Range(0, 1)) = 0
		_Brightness ("Brightness", Range(0, 1)) = 1
		_myTintColor ("Tint Color", Vector) = (0.25,0.25,0.25,1)
		_Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
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
	Fallback "Avalon2/Default/TransparentCutoutVertexLit"
}