Shader "BeSync/BeSync_LookUpTexture" {
	Properties 
	{
		_EmissiveColor ("Emissive Color", Color) = (1,1,1,1)
		_AmbientColor  ("Ambient Color", Color) = (1,1,1,1)
		_Brightness ("Brightness", Range(0,10)) = 2.5
		_RampTex ("Ramp Texture", 2D) = "white"{}
	}
	
	SubShader 
	{
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf SimpleLambert exclude_path:prepass nolightmap noforwardadd halfasview

		float4 _EmissiveColor;
		float4 _AmbientColor;
		float _Brightness;
		sampler2D _RampTex;
		
		inline float4 LightingSimpleLambert (SurfaceOutput s, float3 lightDir, float atten)
		{
			float difLight = dot (s.Normal, lightDir);
			float hLambert = difLight * 0.5 + 0.5;
			float3 ramp = tex2D(_RampTex, float2(hLambert,1)).rgb;
			
			float4 col;
			col.rgb = s.Albedo * _LightColor0.rgb * (ramp);
			col.a = s.Alpha;
			return col;
		}

		struct Input 
		{
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) 
		{
			float4 c;
			c =  pow((_EmissiveColor + _AmbientColor), _Brightness);
			
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		
		ENDCG
	} 
	
	FallBack "Diffuse"
}
