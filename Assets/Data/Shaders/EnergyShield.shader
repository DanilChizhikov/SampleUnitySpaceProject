Shader "Shields/EnergyShield"
{
    Properties
    {
        _MainTex("Albedo (RGB)", 2D) = "white" {}
        _ShieldColor("Shield Color", Color) = (1, 0, 0, 1)

        _MaskTex("Noise Mask", 2D) = "black" {}
        //_DepthColor("Depth Color", Color)

        _ShieldIntensity("Shield Intensity", Range(0,1)) = 1.0

        _ScrollSpeedU("Scroll U Speed", float) = 2
        _ScrollSpeedV("Scroll V Speed", float) = 0

        _WorldHitPoint0("Hit Point 0", Vector) = (0, 1, 0, 0)
        _WorldHitTime0("Hit Time 0", float) = -1000

        _WorldHitPoint1("Hit Point 1", Vector) = (0, 1, 0, 0)
        _WorldHitTime1("Hit Time 1", float) = -1000

        _WorldHitPoint2("Hit Point 2", Vector) = (0, 1, 0, 0)
        _WorldHitTime2("Hit Time 2", float) = -1000

        _HitDuration("Hit Duration", float) = 10.0
        _MaxDistance("MaxDistance", float) = 0.5

    }
        SubShader
        {
            Tags { "Queue" = "Transparent" "RenderType" = "Transparent" }
            ZWrite Off
            Cull Off
            Blend SrcAlpha OneMinusSrcAlpha

            Pass
            {
                CGPROGRAM
                #pragma vertex vert
                #pragma fragment frag

                #include "UnityCG.cginc"

                sampler2D 
                    _MainTex,
                    _MaskTex
                    ;

                half4
                    _MainTex_ST,
                    _MaskTex_ST,
                    _ShieldColor,
                    _WaveColor
                    ;

                half
                    _ShieldIntensity,
                    _ScrollSpeedU,
                    _ScrollSpeedV,
                    _TimeScale,
                    _MaxDistance,
                    _HitDuration,
                    _HitTime0,
                    _HitTime1,
                    _HitTime2
                    ;

                float4
                    _WorldHitPoint0,
                    _WorldHitPoint1,
                    _WorldHitPoint2
                    ;

                struct appdata
                {
                    float4 vertex : POSITION;
                    float3 normal: NORMAL;
                    float2 uv : TEXCOORD0;
                    float2 uvMask : TEXCOORD1;
                };

                struct v2f
                {
                    float2 uv : TEXCOORD0;
                    float2 uvMask : TEXCOORD1;
                    float intensity : COLOR0;
                    float4 vertex : SV_POSITION;
                    fixed4 screenPos : TEXCOORD2;
                };

                v2f vert(appdata v)
                {
                    v2f o;
                    o.vertex = UnityObjectToClipPos(v.vertex);;
                    o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                    o.uvMask = TRANSFORM_TEX(v.uvMask, _MaskTex);

                    o.uvMask.x += _Time * _ScrollSpeedU;
                    o.uvMask.y += _Time * _ScrollSpeedV;

                    float4 worldVertex = mul(unity_ObjectToWorld, v.vertex);
                    float3 normWorld = normalize(mul(unity_ObjectToWorld, v.normal));
                    float3 I = normalize(worldVertex - _WorldSpaceCameraPos.xyz);

                    float t0 = saturate((_Time.y - _HitTime0) / _HitDuration);
                    float d0 = saturate(distance(worldVertex.xyz, _WorldHitPoint0.xyz) / (_MaxDistance));


                    float t1 = saturate((_Time.y - _HitTime1) / _HitDuration);
                    float d1 = saturate(distance(worldVertex.xyz, _WorldHitPoint1.xyz) / (_MaxDistance));


                    float t2 = saturate((_Time.y - _HitTime2) / _HitDuration);
                    float d2 = saturate(distance(worldVertex.xyz, _WorldHitPoint2.xyz) / (_MaxDistance));


                    float hitIntensity = (1 - t0) * ((1 / (d0)) - 1) +
                        (1 - t1) * ((1 / (d1)) - 1) +
                        (1 - t2) * ((1 / (d2)) - 1);

                    o.intensity = hitIntensity;

                    return o;
                }

                fixed4 frag(v2f i) : SV_Target
                {
                    fixed3 mask = tex2D(_MaskTex, i.uvMask);
                    fixed3 col = tex2D(_MainTex, i.uv);

                    fixed4 result = fixed4(_ShieldColor.r + col.r, _ShieldColor.g + col.g, _ShieldColor.b + col.b, saturate(_ShieldIntensity + i.intensity));
                    return fixed4(result.rgb * mask, result.a);
                }
                ENDCG
            }
        }
}