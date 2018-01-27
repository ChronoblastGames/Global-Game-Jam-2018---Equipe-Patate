// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:32790,y:32520,varname:node_4013,prsc:2|diff-8716-OUT,clip-5584-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:31961,y:32387,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:5859,x:31961,y:32542,ptovrint:False,ptlb:ScanlineTexture,ptin:_ScanlineTexture,varname:node_5859,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:2fe7869901a119d4085126a8f852ebd9,ntxv:0,isnm:False|UVIN-583-OUT;n:type:ShaderForge.SFN_Multiply,id:8716,x:32415,y:32639,varname:node_8716,prsc:2|A-1304-RGB,B-5859-RGB;n:type:ShaderForge.SFN_Slider,id:6011,x:32198,y:32916,ptovrint:False,ptlb:TransparencyOfScanline,ptin:_TransparencyOfScanline,varname:node_6011,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7361153,max:1;n:type:ShaderForge.SFN_Step,id:5584,x:32526,y:32803,varname:node_5584,prsc:2|A-5859-A,B-6011-OUT;n:type:ShaderForge.SFN_Panner,id:9990,x:31381,y:32517,varname:node_9990,prsc:2,spu:1,spv:1|UVIN-619-UVOUT,DIST-7426-OUT;n:type:ShaderForge.SFN_Append,id:9070,x:31301,y:32709,varname:node_9070,prsc:2|A-1890-R,B-1890-G;n:type:ShaderForge.SFN_Add,id:583,x:31720,y:32522,varname:node_583,prsc:2|A-2417-UVOUT,B-8483-OUT;n:type:ShaderForge.SFN_TexCoord,id:2417,x:31628,y:32260,varname:node_2417,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:9825,x:31551,y:32760,varname:node_9825,prsc:2|A-9070-OUT,B-4193-OUT;n:type:ShaderForge.SFN_Tex2d,id:1890,x:31014,y:32738,ptovrint:False,ptlb:StaticTexture,ptin:_StaticTexture,varname:node_1890,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:e958c6041cfe445e987c73751e8d4082,ntxv:2,isnm:False|UVIN-9990-UVOUT;n:type:ShaderForge.SFN_Slider,id:4193,x:31199,y:32855,ptovrint:False,ptlb:Intensity of Static,ptin:_IntensityofStatic,varname:node_4193,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.02564103,max:1;n:type:ShaderForge.SFN_TexCoord,id:619,x:31381,y:32368,varname:node_619,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:1208,x:30998,y:32432,varname:node_1208,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7426,x:31206,y:32527,varname:node_7426,prsc:2|A-1208-TDB,B-447-OUT;n:type:ShaderForge.SFN_Slider,id:447,x:30841,y:32612,ptovrint:False,ptlb:Intensity of Satic Panning,ptin:_IntensityofSaticPanning,varname:node_447,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.902277,max:1;n:type:ShaderForge.SFN_Multiply,id:4344,x:31663,y:32926,varname:node_4344,prsc:2|A-343-OUT,B-6285-OUT;n:type:ShaderForge.SFN_Panner,id:9345,x:31259,y:33113,varname:node_9345,prsc:2,spu:0,spv:1|UVIN-8218-UVOUT,DIST-7016-OUT;n:type:ShaderForge.SFN_Append,id:343,x:31422,y:33285,varname:node_343,prsc:2|A-2103-R,B-2103-G;n:type:ShaderForge.SFN_Tex2d,id:2103,x:31152,y:33313,ptovrint:False,ptlb:DistortionTexture,ptin:_DistortionTexture,varname:_StaticTexture_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:885fcb01fbb73194bbe07a0886128be7,ntxv:2,isnm:False|UVIN-9345-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8218,x:31179,y:32959,varname:node_8218,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:1397,x:30894,y:33018,varname:node_1397,prsc:2;n:type:ShaderForge.SFN_Multiply,id:7016,x:31065,y:33138,varname:node_7016,prsc:2|A-1397-TTR,B-5357-OUT;n:type:ShaderForge.SFN_Slider,id:5357,x:30737,y:33198,ptovrint:False,ptlb:Intensity of Jitter Panning,ptin:_IntensityofJitterPanning,varname:_IntensityofSaticPanning_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1495596,max:1;n:type:ShaderForge.SFN_Slider,id:6285,x:31322,y:33489,ptovrint:False,ptlb:Intensity of jitter,ptin:_Intensityofjitter,varname:_IntensityofStatic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3375902,max:1;n:type:ShaderForge.SFN_Multiply,id:8483,x:31859,y:32896,varname:node_8483,prsc:2|A-9825-OUT,B-4344-OUT;proporder:1304-5859-6011-1890-4193-447-2103-6285-5357;pass:END;sub:END;*/

Shader "Shader Forge/Scanlines" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _ScanlineTexture ("ScanlineTexture", 2D) = "white" {}
        _TransparencyOfScanline ("TransparencyOfScanline", Range(0, 1)) = 0.7361153
        _StaticTexture ("StaticTexture", 2D) = "black" {}
        _IntensityofStatic ("Intensity of Static", Range(0, 1)) = 0.02564103
        _IntensityofSaticPanning ("Intensity of Satic Panning", Range(0, 1)) = 0.902277
        _DistortionTexture ("DistortionTexture", 2D) = "black" {}
        _Intensityofjitter ("Intensity of jitter", Range(0, 1)) = 0.3375902
        _IntensityofJitterPanning ("Intensity of Jitter Panning", Range(0, 1)) = 0.1495596
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _Color;
            uniform sampler2D _ScanlineTexture; uniform float4 _ScanlineTexture_ST;
            uniform float _TransparencyOfScanline;
            uniform sampler2D _StaticTexture; uniform float4 _StaticTexture_ST;
            uniform float _IntensityofStatic;
            uniform float _IntensityofSaticPanning;
            uniform sampler2D _DistortionTexture; uniform float4 _DistortionTexture_ST;
            uniform float _IntensityofJitterPanning;
            uniform float _Intensityofjitter;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 node_1208 = _Time;
                float2 node_9990 = (i.uv0+(node_1208.b*_IntensityofSaticPanning)*float2(1,1));
                float4 _StaticTexture_var = tex2D(_StaticTexture,TRANSFORM_TEX(node_9990, _StaticTexture));
                float4 node_1397 = _Time;
                float2 node_9345 = (i.uv0+(node_1397.a*_IntensityofJitterPanning)*float2(0,1));
                float4 _DistortionTexture_var = tex2D(_DistortionTexture,TRANSFORM_TEX(node_9345, _DistortionTexture));
                float2 node_583 = (i.uv0+((float2(_StaticTexture_var.r,_StaticTexture_var.g)*_IntensityofStatic)*(float2(_DistortionTexture_var.r,_DistortionTexture_var.g)*_Intensityofjitter)));
                float4 _ScanlineTexture_var = tex2D(_ScanlineTexture,TRANSFORM_TEX(node_583, _ScanlineTexture));
                clip(step(_ScanlineTexture_var.a,_TransparencyOfScanline) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = (_Color.rgb*_ScanlineTexture_var.rgb);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform float4 _Color;
            uniform sampler2D _ScanlineTexture; uniform float4 _ScanlineTexture_ST;
            uniform float _TransparencyOfScanline;
            uniform sampler2D _StaticTexture; uniform float4 _StaticTexture_ST;
            uniform float _IntensityofStatic;
            uniform float _IntensityofSaticPanning;
            uniform sampler2D _DistortionTexture; uniform float4 _DistortionTexture_ST;
            uniform float _IntensityofJitterPanning;
            uniform float _Intensityofjitter;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 node_1208 = _Time;
                float2 node_9990 = (i.uv0+(node_1208.b*_IntensityofSaticPanning)*float2(1,1));
                float4 _StaticTexture_var = tex2D(_StaticTexture,TRANSFORM_TEX(node_9990, _StaticTexture));
                float4 node_1397 = _Time;
                float2 node_9345 = (i.uv0+(node_1397.a*_IntensityofJitterPanning)*float2(0,1));
                float4 _DistortionTexture_var = tex2D(_DistortionTexture,TRANSFORM_TEX(node_9345, _DistortionTexture));
                float2 node_583 = (i.uv0+((float2(_StaticTexture_var.r,_StaticTexture_var.g)*_IntensityofStatic)*(float2(_DistortionTexture_var.r,_DistortionTexture_var.g)*_Intensityofjitter)));
                float4 _ScanlineTexture_var = tex2D(_ScanlineTexture,TRANSFORM_TEX(node_583, _ScanlineTexture));
                clip(step(_ScanlineTexture_var.a,_TransparencyOfScanline) - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 diffuseColor = (_Color.rgb*_ScanlineTexture_var.rgb);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _ScanlineTexture; uniform float4 _ScanlineTexture_ST;
            uniform float _TransparencyOfScanline;
            uniform sampler2D _StaticTexture; uniform float4 _StaticTexture_ST;
            uniform float _IntensityofStatic;
            uniform float _IntensityofSaticPanning;
            uniform sampler2D _DistortionTexture; uniform float4 _DistortionTexture_ST;
            uniform float _IntensityofJitterPanning;
            uniform float _Intensityofjitter;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 node_1208 = _Time;
                float2 node_9990 = (i.uv0+(node_1208.b*_IntensityofSaticPanning)*float2(1,1));
                float4 _StaticTexture_var = tex2D(_StaticTexture,TRANSFORM_TEX(node_9990, _StaticTexture));
                float4 node_1397 = _Time;
                float2 node_9345 = (i.uv0+(node_1397.a*_IntensityofJitterPanning)*float2(0,1));
                float4 _DistortionTexture_var = tex2D(_DistortionTexture,TRANSFORM_TEX(node_9345, _DistortionTexture));
                float2 node_583 = (i.uv0+((float2(_StaticTexture_var.r,_StaticTexture_var.g)*_IntensityofStatic)*(float2(_DistortionTexture_var.r,_DistortionTexture_var.g)*_Intensityofjitter)));
                float4 _ScanlineTexture_var = tex2D(_ScanlineTexture,TRANSFORM_TEX(node_583, _ScanlineTexture));
                clip(step(_ScanlineTexture_var.a,_TransparencyOfScanline) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
