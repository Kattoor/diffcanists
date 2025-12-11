
using System;
using System.Runtime.CompilerServices;

public class FastNoiseLite
{
  private static readonly float[] Gradients2D = new float[256]
  {
    0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.6087614f,
    0.7933533f,
    0.7933533f,
    0.6087614f,
    0.9238795f,
    0.3826834f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    -0.1305262f,
    0.9238795f,
    -0.3826834f,
    0.7933533f,
    -0.6087614f,
    0.6087614f,
    -0.7933533f,
    0.3826834f,
    -0.9238795f,
    0.1305262f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    -0.3826834f,
    -0.9238795f,
    -0.6087614f,
    -0.7933533f,
    -0.7933533f,
    -0.6087614f,
    -0.9238795f,
    -0.3826834f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    0.1305262f,
    -0.9238795f,
    0.3826834f,
    -0.7933533f,
    0.6087614f,
    -0.6087614f,
    0.7933533f,
    -0.3826834f,
    0.9238795f,
    -0.1305262f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.6087614f,
    0.7933533f,
    0.7933533f,
    0.6087614f,
    0.9238795f,
    0.3826834f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    -0.1305262f,
    0.9238795f,
    -0.3826834f,
    0.7933533f,
    -0.6087614f,
    0.6087614f,
    -0.7933533f,
    0.3826834f,
    -0.9238795f,
    0.1305262f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    -0.3826834f,
    -0.9238795f,
    -0.6087614f,
    -0.7933533f,
    -0.7933533f,
    -0.6087614f,
    -0.9238795f,
    -0.3826834f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    0.1305262f,
    -0.9238795f,
    0.3826834f,
    -0.7933533f,
    0.6087614f,
    -0.6087614f,
    0.7933533f,
    -0.3826834f,
    0.9238795f,
    -0.1305262f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.6087614f,
    0.7933533f,
    0.7933533f,
    0.6087614f,
    0.9238795f,
    0.3826834f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    -0.1305262f,
    0.9238795f,
    -0.3826834f,
    0.7933533f,
    -0.6087614f,
    0.6087614f,
    -0.7933533f,
    0.3826834f,
    -0.9238795f,
    0.1305262f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    -0.3826834f,
    -0.9238795f,
    -0.6087614f,
    -0.7933533f,
    -0.7933533f,
    -0.6087614f,
    -0.9238795f,
    -0.3826834f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    0.1305262f,
    -0.9238795f,
    0.3826834f,
    -0.7933533f,
    0.6087614f,
    -0.6087614f,
    0.7933533f,
    -0.3826834f,
    0.9238795f,
    -0.1305262f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.6087614f,
    0.7933533f,
    0.7933533f,
    0.6087614f,
    0.9238795f,
    0.3826834f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    -0.1305262f,
    0.9238795f,
    -0.3826834f,
    0.7933533f,
    -0.6087614f,
    0.6087614f,
    -0.7933533f,
    0.3826834f,
    -0.9238795f,
    0.1305262f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    -0.3826834f,
    -0.9238795f,
    -0.6087614f,
    -0.7933533f,
    -0.7933533f,
    -0.6087614f,
    -0.9238795f,
    -0.3826834f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    0.1305262f,
    -0.9238795f,
    0.3826834f,
    -0.7933533f,
    0.6087614f,
    -0.6087614f,
    0.7933533f,
    -0.3826834f,
    0.9238795f,
    -0.1305262f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.6087614f,
    0.7933533f,
    0.7933533f,
    0.6087614f,
    0.9238795f,
    0.3826834f,
    0.9914449f,
    0.1305262f,
    0.9914449f,
    -0.1305262f,
    0.9238795f,
    -0.3826834f,
    0.7933533f,
    -0.6087614f,
    0.6087614f,
    -0.7933533f,
    0.3826834f,
    -0.9238795f,
    0.1305262f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    -0.3826834f,
    -0.9238795f,
    -0.6087614f,
    -0.7933533f,
    -0.7933533f,
    -0.6087614f,
    -0.9238795f,
    -0.3826834f,
    -0.9914449f,
    -0.1305262f,
    -0.9914449f,
    0.1305262f,
    -0.9238795f,
    0.3826834f,
    -0.7933533f,
    0.6087614f,
    -0.6087614f,
    0.7933533f,
    -0.3826834f,
    0.9238795f,
    -0.1305262f,
    0.9914449f,
    0.3826834f,
    0.9238795f,
    0.9238795f,
    0.3826834f,
    0.9238795f,
    -0.3826834f,
    0.3826834f,
    -0.9238795f,
    -0.3826834f,
    -0.9238795f,
    -0.9238795f,
    -0.3826834f,
    -0.9238795f,
    0.3826834f,
    -0.3826834f,
    0.9238795f
  };
  private static readonly float[] RandVecs2D = new float[512]
  {
    -0.2700222f,
    -0.9628541f,
    0.3863093f,
    -0.9223693f,
    0.04444859f,
    -0.9990117f,
    -0.5992523f,
    -0.8005602f,
    -0.781928f,
    0.6233687f,
    0.9464672f,
    0.3227999f,
    -0.6514147f,
    -0.7587219f,
    0.9378473f,
    0.3470484f,
    -0.8497876f,
    -0.5271252f,
    -0.8790426f,
    0.4767433f,
    -0.8923003f,
    -0.4514424f,
    -0.3798444f,
    -0.9250504f,
    -0.9951651f,
    0.09821638f,
    0.7724398f,
    -0.635088f,
    0.7573283f,
    -0.6530343f,
    -0.9928005f,
    -0.1197801f,
    -0.05326657f,
    0.9985803f,
    0.9754254f,
    -0.2203301f,
    -0.7665018f,
    0.6422421f,
    0.9916367f,
    0.1290606f,
    -0.9946969f,
    0.1028504f,
    -0.5379205f,
    -0.8429955f,
    0.5022815f,
    -0.8647041f,
    0.4559821f,
    -0.8899889f,
    -0.8659131f,
    -0.5001944f,
    0.08794584f,
    -0.9961253f,
    -0.5051685f,
    0.8630207f,
    0.7753185f,
    -0.6315704f,
    -0.6921945f,
    0.721711f,
    -0.5191659f,
    -0.8546734f,
    0.8978623f,
    -0.4402764f,
    -0.1706774f,
    0.9853269f,
    -0.935343f,
    -0.3537421f,
    -0.9992405f,
    0.03896747f,
    -0.2882064f,
    -0.9575683f,
    -0.9663811f,
    0.2571138f,
    -0.8759714f,
    -0.482363f,
    -0.8303123f,
    -0.5572984f,
    0.05110134f,
    -0.9986935f,
    -0.8558373f,
    -0.5172451f,
    0.09887026f,
    0.9951003f,
    0.9189016f,
    0.3944868f,
    -0.2439376f,
    -0.9697909f,
    -0.8121409f,
    -0.5834613f,
    -0.9910432f,
    0.1335421f,
    0.8492424f,
    -0.5280032f,
    -0.9717839f,
    -0.235873f,
    0.9949457f,
    0.1004142f,
    0.6241065f,
    -0.7813392f,
    0.6629103f,
    0.7486988f,
    -0.7197418f,
    0.6942418f,
    -0.8143371f,
    -0.5803922f,
    0.1045211f,
    -0.9945227f,
    -0.1065926f,
    -0.9943027f,
    0.4457997f,
    -0.8951328f,
    0.1055474f,
    0.9944143f,
    -0.9927903f,
    0.1198644f,
    -0.8334367f,
    0.552615f,
    0.9115562f,
    -0.4111756f,
    0.8285545f,
    -0.5599084f,
    0.7217098f,
    -0.6921958f,
    0.4940493f,
    -0.8694339f,
    -0.3652321f,
    -0.9309165f,
    -0.9696607f,
    0.2444548f,
    0.08925509f,
    -0.9960088f,
    0.5354071f,
    -0.8445941f,
    -0.1053576f,
    0.9944344f,
    -0.9890285f,
    0.1477251f,
    0.004856105f,
    0.9999882f,
    0.9885598f,
    0.1508291f,
    0.9286129f,
    -0.3710498f,
    -0.5832394f,
    -0.8123003f,
    0.3015208f,
    0.9534596f,
    -0.9575111f,
    0.2883966f,
    0.9715802f,
    -0.2367105f,
    0.2299818f,
    0.973195f,
    0.9557638f,
    -0.2941352f,
    0.7409561f,
    0.6715534f,
    -0.9971514f,
    -0.07542631f,
    0.6905711f,
    -0.7232645f,
    -0.2907137f,
    -0.9568101f,
    0.5912778f,
    -0.806468f,
    -0.9454592f,
    -0.3257405f,
    0.6664456f,
    0.7455537f,
    0.6236135f,
    0.7817329f,
    0.9126994f,
    -0.4086317f,
    -0.8191762f,
    0.5735419f,
    -0.8812746f,
    -0.4726046f,
    0.9953313f,
    0.09651673f,
    0.9855651f,
    -0.169297f,
    -0.8495981f,
    0.5274307f,
    0.6174854f,
    -0.7865824f,
    0.8508157f,
    0.5254643f,
    0.9985033f,
    -0.0546925f,
    0.1971372f,
    -0.9803759f,
    0.6607856f,
    -0.7505747f,
    -0.03097494f,
    0.9995202f,
    -0.6731661f,
    0.7394913f,
    -0.7195019f,
    -0.6944906f,
    0.9727511f,
    0.2318516f,
    0.9997059f,
    -0.02425069f,
    0.4421788f,
    -0.8969269f,
    0.9981351f,
    -0.06104367f,
    -0.9173661f,
    -0.3980446f,
    -0.8150057f,
    -0.579453f,
    -0.8789331f,
    0.476945f,
    0.01586058f,
    0.9998742f,
    -0.8095465f,
    0.5870558f,
    -0.9165899f,
    -0.3998287f,
    -0.8023543f,
    0.5968481f,
    -0.5176738f,
    0.8555781f,
    -95f * (float) Math.PI / 366f,
    -0.5788406f,
    0.402201f,
    -0.9155514f,
    -0.9052557f,
    -0.4248672f,
    0.7317446f,
    0.681579f,
    -0.5647632f,
    -0.825253f,
    -0.8403276f,
    -0.5420789f,
    -0.9314281f,
    0.3639252f,
    0.5238199f,
    0.8518291f,
    0.7432804f,
    -0.66898f,
    -0.9853716f,
    -0.1704197f,
    0.4601469f,
    0.8878428f,
    0.8258554f,
    0.5638819f,
    0.6182366f,
    0.785992f,
    0.8331503f,
    -0.5530466f,
    0.1500307f,
    0.9886813f,
    -0.6623304f,
    -0.7492119f,
    -0.6685987f,
    0.7436234f,
    0.7025606f,
    0.7116239f,
    -0.541939f,
    -0.8404179f,
    -0.3388616f,
    0.9408362f,
    0.833153f,
    0.5530425f,
    -0.2989721f,
    -0.9542618f,
    0.2638523f,
    0.9645631f,
    0.1241087f,
    -0.9922686f,
    -0.7282649f,
    -0.6852957f,
    0.69625f,
    0.7177994f,
    -0.9183536f,
    0.395761f,
    -0.6326102f,
    -0.7744703f,
    -0.9331892f,
    -0.3593855f,
    -0.1153779f,
    -0.9933217f,
    0.9514975f,
    -0.3076566f,
    -0.08987977f,
    -0.9959526f,
    0.6678497f,
    0.7442962f,
    0.79524f,
    -0.6062947f,
    -0.6462007f,
    -0.7631675f,
    -0.2733599f,
    0.9619119f,
    0.966959f,
    -0.2549318f,
    -0.9792895f,
    0.2024652f,
    -0.5369503f,
    -0.8436139f,
    -0.2700365f,
    -0.9628501f,
    -0.6400277f,
    0.7683519f,
    -0.7854537f,
    -0.6189204f,
    0.06005906f,
    -0.9981948f,
    -0.0245577f,
    0.9996984f,
    -1080f / (521f * Math.PI),
    0.7514095f,
    -0.6253895f,
    -0.7803128f,
    -0.6210409f,
    -0.7837782f,
    0.8348889f,
    0.5504186f,
    -0.1592275f,
    0.9872419f,
    0.8367622f,
    0.5475664f,
    -0.8675754f,
    -0.4973057f,
    -0.2022663f,
    -0.9793305f,
    0.939919f,
    0.3413976f,
    0.9877405f,
    -0.1561049f,
    -0.9034455f,
    0.4287028f,
    0.1269804f,
    -0.9919052f,
    -0.3819601f,
    0.9241788f,
    0.9754626f,
    0.2201653f,
    -0.3204016f,
    -0.9472818f,
    -0.9874761f,
    0.1577687f,
    0.02535348f,
    -0.9996786f,
    0.4835131f,
    -0.8753371f,
    -0.28508f,
    -0.9585037f,
    -0.06805516f,
    -0.9976816f,
    -0.7885244f,
    -0.6150035f,
    0.3185392f,
    -0.9479097f,
    0.8880043f,
    0.4598351f,
    0.6476921f,
    -0.7619022f,
    0.9820241f,
    0.1887554f,
    0.9357275f,
    -0.3527237f,
    -0.8894895f,
    0.4569555f,
    0.7922791f,
    0.6101588f,
    0.7483819f,
    0.6632681f,
    -0.728893f,
    -0.6846277f,
    0.8729033f,
    -0.4878933f,
    0.8288346f,
    0.5594937f,
    0.08074567f,
    0.9967347f,
    0.9799148f,
    -0.1994165f,
    -0.5807307f,
    -0.8140957f,
    -0.470005f,
    -0.8826638f,
    0.2409493f,
    0.9705377f,
    0.9437817f,
    -0.3305694f,
    -0.8927999f,
    -0.4504535f,
    -0.8069623f,
    0.5906031f,
    0.06258973f,
    0.9980394f,
    -0.9312598f,
    0.364356f,
    0.577745f,
    0.8162174f,
    -0.3360096f,
    -0.9418586f,
    0.6979321f,
    -0.7161639f,
    -0.002008157f,
    -0.999998f,
    -0.1827294f,
    -0.9831632f,
    -0.6523912f,
    0.7578824f,
    -0.4302627f,
    -0.9027037f,
    -0.9985126f,
    -0.05452091f,
    -0.01028102f,
    -0.9999471f,
    -0.4946071f,
    0.8691167f,
    -0.299935f,
    0.9539596f,
    0.8165472f,
    0.5772787f,
    0.269746f,
    0.9629315f,
    -0.7306287f,
    -0.682775f,
    -0.7590952f,
    -0.6509796f,
    -0.9070538f,
    0.4210146f,
    -0.5104861f,
    -0.859886f,
    0.861335f,
    0.5080373f,
    0.5007882f,
    -0.8655699f,
    -0.6541582f,
    0.7563578f,
    -0.8382756f,
    -0.5452468f,
    0.6940071f,
    0.7199682f,
    0.06950936f,
    0.9975813f,
    0.1702942f,
    -0.9853933f,
    0.2695973f,
    0.9629731f,
    0.5519612f,
    -0.8338698f,
    0.2256575f,
    -0.9742067f,
    0.4215263f,
    -0.9068162f,
    0.4881873f,
    -0.8727388f,
    -0.3683855f,
    -0.9296731f,
    -0.9825391f,
    0.1860565f,
    0.8125647f,
    0.582871f,
    0.3196461f,
    -0.947537f,
    0.9570914f,
    0.2897862f,
    -0.6876655f,
    -0.7260276f,
    -0.9988771f,
    -0.04737673f,
    -0.1250179f,
    0.9921545f,
    -0.8280134f,
    0.5607083f,
    0.9324864f,
    -0.3612051f,
    0.6394653f,
    0.7688199f,
    -0.01623847f,
    -0.9998682f,
    -0.9955015f,
    -0.09474614f,
    -0.8145332f,
    0.580117f,
    0.4037328f,
    -0.9148769f,
    0.9944263f,
    0.1054337f,
    -0.1624712f,
    0.9867133f,
    -0.9949488f,
    -0.1003839f,
    -0.6995302f,
    0.714603f,
    0.5263415f,
    -0.8502733f,
    -96f * (float) Math.PI / 559f,
    0.8419714f,
    0.657937f,
    0.7530729f,
    0.01426759f,
    -0.9998982f,
    -0.6734384f,
    0.7392433f,
    0.6394121f,
    -0.7688642f,
    0.9211571f,
    0.3891909f,
    -0.1466372f,
    -0.9891903f,
    -0.7823181f,
    0.6228791f,
    -0.5039611f,
    -0.8637264f,
    -0.774312f,
    -0.632804f
  };
  private static readonly float[] Gradients3D = new float[256]
  {
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    0.0f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    0.0f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    0.0f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    0.0f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    0.0f,
    1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    -1f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    1f,
    -1f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f,
    0.0f,
    1f,
    1f,
    0.0f,
    0.0f,
    0.0f,
    -1f,
    1f,
    0.0f,
    -1f,
    1f,
    0.0f,
    0.0f,
    0.0f,
    -1f,
    -1f,
    0.0f
  };
  private static readonly float[] RandVecs3D = new float[1024]
  {
    -0.7292737f,
    -0.661844f,
    0.1735582f,
    0.0f,
    0.7902921f,
    -0.5480887f,
    -0.2739291f,
    0.0f,
    0.7217579f,
    0.6226212f,
    -0.3023381f,
    0.0f,
    0.5656831f,
    -0.8208298f,
    -0.07900003f,
    0.0f,
    0.760049f,
    -0.555598f,
    -0.3371f,
    0.0f,
    0.3713946f,
    0.5011265f,
    0.7816254f,
    0.0f,
    -0.1277062f,
    -0.4254439f,
    -0.8959289f,
    0.0f,
    -0.2881561f,
    -0.5815839f,
    0.7607406f,
    0.0f,
    0.5849561f,
    -0.6628202f,
    -0.4674352f,
    0.0f,
    0.3307171f,
    0.03916537f,
    0.9429169f,
    0.0f,
    0.8712122f,
    -0.4113374f,
    -0.2679382f,
    0.0f,
    0.580981f,
    0.7021916f,
    0.4115678f,
    0.0f,
    0.5037569f,
    0.6330057f,
    -0.5878204f,
    0.0f,
    0.4493712f,
    0.6013902f,
    0.6606023f,
    0.0f,
    -0.6878404f,
    0.09018891f,
    -0.7202372f,
    0.0f,
    -0.5958956f,
    -0.646935f,
    0.4757977f,
    0.0f,
    -0.5127052f,
    0.1946922f,
    -0.8361987f,
    0.0f,
    -0.9911507f,
    -0.05410276f,
    -0.1212153f,
    0.0f,
    -0.2149721f,
    0.9720882f,
    -0.09397608f,
    0.0f,
    -0.7518651f,
    -0.5428057f,
    0.374247f,
    0.0f,
    0.5237069f,
    0.8516377f,
    -0.02107818f,
    0.0f,
    0.6333505f,
    0.1926167f,
    -0.7495105f,
    0.0f,
    -0.06788242f,
    0.3998306f,
    0.9140719f,
    0.0f,
    -0.5538629f,
    -0.4729897f,
    -0.6852129f,
    0.0f,
    -0.7261456f,
    -0.5911991f,
    0.3509933f,
    0.0f,
    -0.9229275f,
    -0.1782809f,
    0.3412049f,
    0.0f,
    -0.6968815f,
    0.6511275f,
    0.300648f,
    0.0f,
    0.9608045f,
    -0.2098363f,
    -0.1811725f,
    0.0f,
    0.06817146f,
    -0.9743405f,
    0.2145069f,
    0.0f,
    -0.3577285f,
    -0.6697087f,
    -0.6507846f,
    0.0f,
    -0.1868621f,
    0.7648617f,
    -0.6164975f,
    0.0f,
    -0.6541697f,
    0.3967915f,
    0.6439087f,
    0.0f,
    0.699334f,
    -0.6164538f,
    0.3618239f,
    0.0f,
    -0.1546666f,
    0.6291284f,
    0.7617583f,
    0.0f,
    -0.6841613f,
    -0.2580482f,
    -0.6821542f,
    0.0f,
    0.5383981f,
    0.4258655f,
    0.727163f,
    0.0f,
    -0.5026988f,
    -0.7939833f,
    -0.3418837f,
    0.0f,
    0.3202972f,
    0.2834415f,
    0.9039196f,
    0.0f,
    0.8683227f,
    -0.0003762656f,
    -0.4959995f,
    0.0f,
    0.7911201f,
    -0.08511046f,
    0.6057106f,
    0.0f,
    -0.04011016f,
    -0.4397249f,
    0.8972364f,
    0.0f,
    0.914512f,
    0.3579346f,
    -0.1885488f,
    0.0f,
    -0.9612039f,
    -0.2756484f,
    0.01024667f,
    0.0f,
    0.6510361f,
    -0.2877799f,
    -0.7023779f,
    0.0f,
    -0.2041786f,
    0.7365237f,
    0.6448596f,
    0.0f,
    -0.7718264f,
    0.3790627f,
    0.5104856f,
    0.0f,
    -0.3060083f,
    -0.7692988f,
    0.5608371f,
    0.0f,
    0.4540073f,
    -0.5024843f,
    0.73579f,
    0.0f,
    0.4816796f,
    0.6021208f,
    -0.636738f,
    0.0f,
    0.696198f,
    -0.3222197f,
    0.6414692f,
    0.0f,
    -0.6532161f,
    -0.6781149f,
    0.3368516f,
    0.0f,
    0.5089301f,
    -0.6154662f,
    -0.6018234f,
    0.0f,
    -0.163592f,
    -0.9133605f,
    -0.3728409f,
    0.0f,
    0.5240802f,
    -0.8437664f,
    0.1157506f,
    0.0f,
    0.5902587f,
    0.4983818f,
    -0.6349884f,
    0.0f,
    0.5863228f,
    0.4947647f,
    0.6414308f,
    0.0f,
    0.6779335f,
    0.2341345f,
    0.6968409f,
    0.0f,
    0.7177054f,
    -0.6858979f,
    0.1201786f,
    0.0f,
    -0.532882f,
    -0.5205125f,
    0.6671608f,
    0.0f,
    -0.8654874f,
    -0.07007271f,
    -0.4960054f,
    0.0f,
    -0.286181f,
    0.7952089f,
    0.5345495f,
    0.0f,
    -0.0484953f,
    0.9810836f,
    -0.1874116f,
    0.0f,
    -0.6358522f,
    0.6058348f,
    0.47818f,
    0.0f,
    0.6254795f,
    -0.286162f,
    0.7258697f,
    0.0f,
    -0.258526f,
    0.5061949f,
    -0.8227582f,
    0.0f,
    0.02136307f,
    0.5064017f,
    -0.862033f,
    0.0f,
    0.2001118f,
    0.8599263f,
    0.4695551f,
    0.0f,
    0.4743561f,
    0.6014985f,
    -0.6427953f,
    0.0f,
    0.6622994f,
    -0.5202475f,
    -0.539168f,
    0.0f,
    0.08084973f,
    -0.653272f,
    0.7527941f,
    0.0f,
    -0.6893687f,
    0.05928604f,
    0.7219805f,
    0.0f,
    -0.1121887f,
    -0.9673185f,
    0.2273953f,
    0.0f,
    0.7344116f,
    0.5979668f,
    -0.3210533f,
    0.0f,
    0.5789393f,
    -0.248885f,
    0.776457f,
    0.0f,
    0.6988183f,
    0.355717f,
    -0.6205791f,
    0.0f,
    -0.8636845f,
    -0.2748771f,
    -0.4224826f,
    0.0f,
    -0.4247028f,
    -0.4640881f,
    0.777335f,
    0.0f,
    0.5257723f,
    -0.8427017f,
    0.115833f,
    0.0f,
    0.934383f,
    0.3163025f,
    -0.1639544f,
    0.0f,
    -0.1016836f,
    -0.8057303f,
    -0.5834888f,
    0.0f,
    -0.6529239f,
    0.5060213f,
    -0.5635893f,
    0.0f,
    -0.2465286f,
    -0.9668206f,
    -0.06694497f,
    0.0f,
    -0.9776897f,
    -0.2099251f,
    -0.007368825f,
    0.0f,
    0.7736893f,
    0.5734245f,
    0.2694238f,
    0.0f,
    -0.6095088f,
    0.4995679f,
    0.6155737f,
    0.0f,
    0.5794535f,
    0.7434547f,
    0.3339292f,
    0.0f,
    -0.8226211f,
    0.08142582f,
    0.5627294f,
    0.0f,
    -0.5103855f,
    0.4703668f,
    0.719904f,
    0.0f,
    -0.5764972f,
    -0.07231656f,
    -0.8138927f,
    0.0f,
    0.7250629f,
    0.3949971f,
    -0.5641463f,
    0.0f,
    -0.1525424f,
    0.4860841f,
    -0.8604958f,
    0.0f,
    -0.5550976f,
    -0.4957821f,
    0.6678823f,
    0.0f,
    -0.1883614f,
    0.914587f,
    0.3578417f,
    0.0f,
    0.7625557f,
    -0.5414408f,
    -0.354049f,
    0.0f,
    -0.5870232f,
    -0.3226498f,
    -0.7424964f,
    0.0f,
    0.3051124f,
    0.2262544f,
    -0.9250488f,
    0.0f,
    0.6379576f,
    0.5772424f,
    -0.509707f,
    0.0f,
    -0.5966776f,
    0.1454852f,
    -0.7891831f,
    0.0f,
    -0.6583306f,
    0.6555488f,
    -0.3699415f,
    0.0f,
    0.7434893f,
    0.2351085f,
    0.6260573f,
    0.0f,
    0.5562114f,
    0.826436f,
    -0.08736329f,
    0.0f,
    -0.302894f,
    -0.8251527f,
    0.4768419f,
    0.0f,
    0.1129344f,
    -0.9858884f,
    -0.1235711f,
    0.0f,
    0.5937653f,
    -0.5896814f,
    0.5474657f,
    0.0f,
    0.6757964f,
    -0.5835758f,
    -0.4502648f,
    0.0f,
    0.7242303f,
    -0.115272f,
    0.679855f,
    0.0f,
    -0.9511914f,
    0.0753624f,
    -0.2992581f,
    0.0f,
    0.2539471f,
    -0.1886339f,
    0.9486454f,
    0.0f,
    0.5714336f,
    -0.1679451f,
    -0.8032796f,
    0.0f,
    -0.06778235f,
    0.3978269f,
    0.9149532f,
    0.0f,
    0.6074973f,
    0.73306f,
    -0.3058923f,
    0.0f,
    -0.5435479f,
    0.1675822f,
    0.8224791f,
    0.0f,
    -133f * (float) Math.PI / 711f,
    -0.3380045f,
    -0.7351187f,
    0.0f,
    -0.7967563f,
    0.04097823f,
    -0.6029099f,
    0.0f,
    -0.1996351f,
    0.8706295f,
    0.4496111f,
    0.0f,
    -0.0278766f,
    -0.9106233f,
    -0.4122962f,
    0.0f,
    -0.7797626f,
    -0.6257635f,
    0.01975776f,
    0.0f,
    -0.5211233f,
    0.7401645f,
    -0.4249555f,
    0.0f,
    0.8575425f,
    0.4053273f,
    -0.3167502f,
    0.0f,
    0.1045223f,
    0.8390196f,
    -0.5339674f,
    0.0f,
    0.3501823f,
    0.9242524f,
    -0.152085f,
    0.0f,
    0.198785f,
    0.07647613f,
    0.9770547f,
    0.0f,
    0.7845997f,
    0.6066257f,
    -0.1280964f,
    0.0f,
    0.09006737f,
    -0.975099f,
    -0.2026569f,
    0.0f,
    -0.8274344f,
    -0.5422996f,
    0.1458204f,
    0.0f,
    -0.3485798f,
    -0.4158023f,
    0.8400004f,
    0.0f,
    -0.2471779f,
    -0.730482f,
    -0.6366311f,
    0.0f,
    -0.3700155f,
    0.8577948f,
    0.3567584f,
    0.0f,
    0.5913395f,
    -0.5483119f,
    -0.5913303f,
    0.0f,
    0.1204874f,
    -0.7626472f,
    -0.6354935f,
    0.0f,
    0.6169593f,
    0.03079648f,
    0.7863923f,
    0.0f,
    0.1258157f,
    -0.664083f,
    -0.7369968f,
    0.0f,
    -0.6477565f,
    -0.1740147f,
    -0.7417077f,
    0.0f,
    0.6217889f,
    -0.7804431f,
    -0.06547655f,
    0.0f,
    0.6589943f,
    -0.6096988f,
    0.4404474f,
    0.0f,
    -0.2689838f,
    -0.6732403f,
    -0.6887636f,
    0.0f,
    -0.3849775f,
    0.5676543f,
    0.7277094f,
    0.0f,
    0.5754445f,
    0.8110471f,
    -0.1051963f,
    0.0f,
    0.9141594f,
    0.3832948f,
    0.1319006f,
    0.0f,
    -0.1079253f,
    0.9245494f,
    0.3654594f,
    0.0f,
    0.3779771f,
    0.3043149f,
    0.8743716f,
    0.0f,
    -0.2142885f,
    -0.8259286f,
    0.5214617f,
    0.0f,
    0.5802544f,
    0.4148099f,
    -0.7008834f,
    0.0f,
    -0.1982661f,
    0.8567162f,
    -0.4761597f,
    0.0f,
    -0.03381554f,
    0.3773181f,
    -0.9254661f,
    0.0f,
    -0.6867923f,
    -0.6656598f,
    0.2919134f,
    0.0f,
    0.7731743f,
    -0.2875794f,
    -0.565243f,
    0.0f,
    -0.09655942f,
    0.9193708f,
    -0.3813575f,
    0.0f,
    0.2715702f,
    -0.957791f,
    -0.09426606f,
    0.0f,
    0.2451016f,
    -0.6917999f,
    -0.6792188f,
    0.0f,
    0.9777008f,
    -0.1753855f,
    0.1155037f,
    0.0f,
    -0.522474f,
    0.8521607f,
    0.02903616f,
    0.0f,
    -0.773488f,
    -0.5261292f,
    0.353418f,
    0.0f,
    -0.7134492f,
    -0.2695473f,
    0.6467878f,
    0.0f,
    0.1644037f,
    0.5105846f,
    -0.8439637f,
    0.0f,
    0.6494636f,
    0.05585611f,
    0.7583384f,
    0.0f,
    -0.4711971f,
    0.5017281f,
    -0.7254256f,
    0.0f,
    -0.6335765f,
    -0.2381686f,
    -0.7361091f,
    0.0f,
    -0.9021533f,
    -0.2709478f,
    -0.3357182f,
    0.0f,
    -0.3793711f,
    0.8722581f,
    0.3086152f,
    0.0f,
    -0.6855599f,
    -0.3250143f,
    0.6514394f,
    0.0f,
    0.2900942f,
    -0.7799058f,
    -0.5546101f,
    0.0f,
    -0.2098319f,
    0.8503707f,
    0.4825352f,
    0.0f,
    -0.4592604f,
    0.6598504f,
    -0.5947077f,
    0.0f,
    0.8715945f,
    0.09616365f,
    -0.4807031f,
    0.0f,
    -0.6776666f,
    0.7118505f,
    -0.1844907f,
    0.0f,
    0.7044378f,
    0.3124276f,
    0.637304f,
    0.0f,
    -0.7052319f,
    -0.2401093f,
    -0.6670798f,
    0.0f,
    0.081921f,
    -0.7207336f,
    -0.6883546f,
    0.0f,
    -0.6993681f,
    -0.5875763f,
    -0.4069869f,
    0.0f,
    -0.1281454f,
    0.6419896f,
    0.7559286f,
    0.0f,
    -0.6337388f,
    -0.6785471f,
    -0.3714147f,
    0.0f,
    0.5565052f,
    -0.2168888f,
    -0.8020357f,
    0.0f,
    -0.5791554f,
    0.7244372f,
    -0.3738579f,
    0.0f,
    0.1175779f,
    -0.7096451f,
    0.6946793f,
    0.0f,
    -0.613462f,
    0.1323631f,
    0.7785528f,
    0.0f,
    0.6984636f,
    -0.02980516f,
    -0.7150247f,
    0.0f,
    0.8318083f,
    -0.3930172f,
    0.3919598f,
    0.0f,
    0.1469576f,
    0.05541652f,
    -0.9875892f,
    0.0f,
    0.7088686f,
    -0.2690504f,
    0.6520101f,
    0.0f,
    0.2726053f,
    0.6736977f,
    -0.6868899f,
    0.0f,
    -0.6591296f,
    0.3035459f,
    -0.6880466f,
    0.0f,
    0.4815131f,
    -0.752827f,
    0.4487723f,
    0.0f,
    0.943001f,
    0.1675647f,
    -0.2875261f,
    0.0f,
    0.4348029f,
    0.7695305f,
    -0.4677278f,
    0.0f,
    0.3931996f,
    0.5944736f,
    0.7014236f,
    0.0f,
    0.7254336f,
    -0.6039256f,
    0.3301815f,
    0.0f,
    0.7590235f,
    -0.6506083f,
    0.02433313f,
    0.0f,
    -0.8552769f,
    -0.3430043f,
    0.3883936f,
    0.0f,
    -0.6139747f,
    0.6981725f,
    0.3682258f,
    0.0f,
    -0.7465906f,
    -0.575201f,
    0.3342849f,
    0.0f,
    0.5730066f,
    0.8105555f,
    -0.1210917f,
    0.0f,
    -0.9225878f,
    -0.3475211f,
    -0.167514f,
    0.0f,
    -0.7105817f,
    -0.4719692f,
    -0.5218417f,
    0.0f,
    -0.0856461f,
    0.3583001f,
    0.9296697f,
    0.0f,
    -0.8279698f,
    -0.2043157f,
    0.5222271f,
    0.0f,
    0.427944f,
    0.278166f,
    0.8599346f,
    0.0f,
    0.539908f,
    -0.7857121f,
    -0.3019204f,
    0.0f,
    0.5678404f,
    -0.5495414f,
    -0.6128308f,
    0.0f,
    -0.9896071f,
    0.1365639f,
    -0.04503419f,
    0.0f,
    -0.6154343f,
    -0.6440876f,
    0.4543037f,
    0.0f,
    0.1074204f,
    -0.794634f,
    0.5975094f,
    0.0f,
    -0.359545f,
    -0.888553f,
    0.2849578f,
    0.0f,
    -0.2180405f,
    0.1529889f,
    0.9638738f,
    0.0f,
    -0.7277432f,
    -0.6164051f,
    -0.3007235f,
    0.0f,
    0.7249729f,
    -0.006697195f,
    0.6887448f,
    0.0f,
    -0.5553659f,
    -0.5336586f,
    0.6377908f,
    0.0f,
    0.5137558f,
    0.7976208f,
    -0.316f,
    0.0f,
    -0.3794025f,
    0.9245608f,
    -0.03522751f,
    0.0f,
    0.8229249f,
    0.2745366f,
    -0.4974177f,
    0.0f,
    -0.5404114f,
    0.6091142f,
    0.5804614f,
    0.0f,
    0.8036582f,
    -0.270303f,
    0.5301602f,
    0.0f,
    0.6044319f,
    0.6832969f,
    0.4095943f,
    0.0f,
    0.06389989f,
    0.9658208f,
    -0.2512108f,
    0.0f,
    0.1087113f,
    0.7402471f,
    -0.6634878f,
    0.0f,
    -0.7134277f,
    -0.6926784f,
    0.1059128f,
    0.0f,
    0.6458898f,
    -0.5724549f,
    -0.5050958f,
    0.0f,
    -0.6553931f,
    0.7381471f,
    0.1599956f,
    0.0f,
    0.3910961f,
    0.9188871f,
    -0.05186756f,
    0.0f,
    -0.4879023f,
    -0.5904377f,
    0.6429111f,
    0.0f,
    0.601479f,
    0.7707441f,
    -0.210182f,
    0.0f,
    -0.5677173f,
    0.7511361f,
    0.3368852f,
    0.0f,
    0.7858574f,
    0.2266747f,
    0.5753667f,
    0.0f,
    -0.4520346f,
    -0.6042227f,
    -0.6561857f,
    0.0f,
    0.002272116f,
    0.4132844f,
    -0.9105992f,
    0.0f,
    -0.5815752f,
    -0.5162926f,
    0.6286591f,
    0.0f,
    -0.03703705f,
    0.8273786f,
    0.5604221f,
    0.0f,
    -0.5119693f,
    0.7953544f,
    -0.324498f,
    0.0f,
    -0.2682417f,
    -0.957229f,
    -0.1084388f,
    0.0f,
    -0.2322483f,
    -0.9679131f,
    -0.09594243f,
    0.0f,
    0.3554329f,
    -0.8881506f,
    0.2913006f,
    0.0f,
    0.734652f,
    -0.4371373f,
    0.5188423f,
    0.0f,
    0.998512f,
    0.04659011f,
    -0.02833945f,
    0.0f,
    -0.3727688f,
    -0.9082481f,
    0.1900757f,
    0.0f,
    0.9173738f,
    -0.3483642f,
    0.1925298f,
    0.0f,
    0.2714911f,
    0.414753f,
    -0.8684887f,
    0.0f,
    0.5131763f,
    -0.7116334f,
    0.4798207f,
    0.0f,
    -0.8737354f,
    0.1888699f,
    -0.4482351f,
    0.0f,
    0.8460044f,
    -0.3725218f,
    0.38145f,
    0.0f,
    0.8978727f,
    -0.1780209f,
    -0.4026575f,
    0.0f,
    0.2178066f,
    -0.9698323f,
    -0.109479f,
    0.0f,
    -0.1518031f,
    -0.7788918f,
    -0.6085091f,
    0.0f,
    -0.2600385f,
    -0.4755398f,
    -0.840382f,
    0.0f,
    0.5723135f,
    -0.7474341f,
    -0.3373418f,
    0.0f,
    -0.7174141f,
    0.1699017f,
    -0.6756111f,
    0.0f,
    -0.6841808f,
    0.02145708f,
    -0.7289968f,
    0.0f,
    -0.2007448f,
    0.06555606f,
    -0.9774477f,
    0.0f,
    -0.1148804f,
    -0.8044887f,
    0.5827524f,
    0.0f,
    -0.787035f,
    0.03447489f,
    0.6159443f,
    0.0f,
    -0.2015596f,
    0.6859872f,
    0.6991389f,
    0.0f,
    -0.08581083f,
    -0.1092084f,
    -0.990308f,
    0.0f,
    0.5532693f,
    0.7325251f,
    -0.3966108f,
    0.0f,
    -0.1842489f,
    -0.9777375f,
    -0.1004077f,
    0.0f,
    0.07754738f,
    -0.9111506f,
    0.404711f,
    0.0f,
    0.1399838f,
    0.7601631f,
    -0.6344734f,
    0.0f,
    0.4484419f,
    -0.8452892f,
    0.2904925f,
    0.0f
  };
  private int mSeed = 1337;
  private float mFrequency = 0.01f;
  private FastNoiseLite.TransformType3D mTransformType3D = FastNoiseLite.TransformType3D.DefaultOpenSimplex2;
  private int mOctaves = 3;
  private float mLacunarity = 2f;
  private float mGain = 0.5f;
  private float mPingPongStength = 2f;
  private float mFractalBounding = 0.5714286f;
  private FastNoiseLite.CellularDistanceFunction mCellularDistanceFunction = FastNoiseLite.CellularDistanceFunction.EuclideanSq;
  private FastNoiseLite.CellularReturnType mCellularReturnType = FastNoiseLite.CellularReturnType.Distance;
  private float mCellularJitterModifier = 1f;
  private FastNoiseLite.TransformType3D mWarpTransformType3D = FastNoiseLite.TransformType3D.DefaultOpenSimplex2;
  private float mDomainWarpAmp = 1f;
  private const short INLINE = 256;
  private const short OPTIMISE = 512;
  private FastNoiseLite.NoiseType mNoiseType;
  private FastNoiseLite.RotationType3D mRotationType3D;
  private FastNoiseLite.FractalType mFractalType;
  private float mWeightedStrength;
  private FastNoiseLite.DomainWarpType mDomainWarpType;
  private const int PrimeX = 501125321;
  private const int PrimeY = 1136930381;
  private const int PrimeZ = 1720413743;

  public FastNoiseLite(int seed = 1337)
  {
    this.SetSeed(seed);
  }

  public void SetSeed(int seed)
  {
    this.mSeed = seed;
  }

  public void SetFrequency(float frequency)
  {
    this.mFrequency = frequency;
  }

  public void SetNoiseType(FastNoiseLite.NoiseType noiseType)
  {
    this.mNoiseType = noiseType;
    this.UpdateTransformType3D();
  }

  public void SetRotationType3D(FastNoiseLite.RotationType3D rotationType3D)
  {
    this.mRotationType3D = rotationType3D;
    this.UpdateTransformType3D();
    this.UpdateWarpTransformType3D();
  }

  public void SetFractalType(FastNoiseLite.FractalType fractalType)
  {
    this.mFractalType = fractalType;
  }

  public void SetFractalOctaves(int octaves)
  {
    this.mOctaves = octaves;
    this.CalculateFractalBounding();
  }

  public void SetFractalLacunarity(float lacunarity)
  {
    this.mLacunarity = lacunarity;
  }

  public void SetFractalGain(float gain)
  {
    this.mGain = gain;
    this.CalculateFractalBounding();
  }

  public void SetFractalWeightedStrength(float weightedStrength)
  {
    this.mWeightedStrength = weightedStrength;
  }

  public void SetFractalPingPongStrength(float pingPongStrength)
  {
    this.mPingPongStength = pingPongStrength;
  }

  public void SetCellularDistanceFunction(
    FastNoiseLite.CellularDistanceFunction cellularDistanceFunction)
  {
    this.mCellularDistanceFunction = cellularDistanceFunction;
  }

  public void SetCellularReturnType(
    FastNoiseLite.CellularReturnType cellularReturnType)
  {
    this.mCellularReturnType = cellularReturnType;
  }

  public void SetCellularJitter(float cellularJitter)
  {
    this.mCellularJitterModifier = cellularJitter;
  }

  public void SetDomainWarpType(FastNoiseLite.DomainWarpType domainWarpType)
  {
    this.mDomainWarpType = domainWarpType;
    this.UpdateWarpTransformType3D();
  }

  public void SetDomainWarpAmp(float domainWarpAmp)
  {
    this.mDomainWarpAmp = domainWarpAmp;
  }

  [MethodImpl((MethodImplOptions) 512)]
  public float GetNoise(float x, float y)
  {
    this.TransformNoiseCoordinate(ref x, ref y);
    switch (this.mFractalType)
    {
      case FastNoiseLite.FractalType.FBm:
        return this.GenFractalFBm(x, y);
      case FastNoiseLite.FractalType.Ridged:
        return this.GenFractalRidged(x, y);
      case FastNoiseLite.FractalType.PingPong:
        return this.GenFractalPingPong(x, y);
      default:
        return this.GenNoiseSingle(this.mSeed, x, y);
    }
  }

  [MethodImpl((MethodImplOptions) 512)]
  public float GetNoise(float x, float y, float z)
  {
    this.TransformNoiseCoordinate(ref x, ref y, ref z);
    switch (this.mFractalType)
    {
      case FastNoiseLite.FractalType.FBm:
        return this.GenFractalFBm(x, y, z);
      case FastNoiseLite.FractalType.Ridged:
        return this.GenFractalRidged(x, y, z);
      case FastNoiseLite.FractalType.PingPong:
        return this.GenFractalPingPong(x, y, z);
      default:
        return this.GenNoiseSingle(this.mSeed, x, y, z);
    }
  }

  [MethodImpl((MethodImplOptions) 512)]
  public void DomainWarp(ref float x, ref float y)
  {
    switch (this.mFractalType)
    {
      case FastNoiseLite.FractalType.DomainWarpProgressive:
        this.DomainWarpFractalProgressive(ref x, ref y);
        break;
      case FastNoiseLite.FractalType.DomainWarpIndependent:
        this.DomainWarpFractalIndependent(ref x, ref y);
        break;
      default:
        this.DomainWarpSingle(ref x, ref y);
        break;
    }
  }

  [MethodImpl((MethodImplOptions) 512)]
  public void DomainWarp(ref float x, ref float y, ref float z)
  {
    switch (this.mFractalType)
    {
      case FastNoiseLite.FractalType.DomainWarpProgressive:
        this.DomainWarpFractalProgressive(ref x, ref y, ref z);
        break;
      case FastNoiseLite.FractalType.DomainWarpIndependent:
        this.DomainWarpFractalIndependent(ref x, ref y, ref z);
        break;
      default:
        this.DomainWarpSingle(ref x, ref y, ref z);
        break;
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float FastMin(float a, float b)
  {
    return (double) a >= (double) b ? b : a;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float FastMax(float a, float b)
  {
    return (double) a <= (double) b ? b : a;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float FastAbs(float f)
  {
    return (double) f >= 0.0 ? f : -f;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float FastSqrt(float f)
  {
    return (float) Math.Sqrt((double) f);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static int FastFloor(float f)
  {
    return (double) f < 0.0 ? (int) f - 1 : (int) f;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static int FastRound(float f)
  {
    return (double) f < 0.0 ? (int) ((double) f - 0.5) : (int) ((double) f + 0.5);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float Lerp(float a, float b, float t)
  {
    return a + t * (b - a);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float InterpHermite(float t)
  {
    return (float) ((double) t * (double) t * (3.0 - 2.0 * (double) t));
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float InterpQuintic(float t)
  {
    return (float) ((double) t * (double) t * (double) t * ((double) t * ((double) t * 6.0 - 15.0) + 10.0));
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float CubicLerp(float a, float b, float c, float d, float t)
  {
    float num = (float) ((double) d - (double) c - ((double) a - (double) b));
    return (float) ((double) t * (double) t * (double) t * (double) num + (double) t * (double) t * ((double) a - (double) b - (double) num) + (double) t * ((double) c - (double) a)) + b;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float PingPong(float t)
  {
    t -= (float) ((int) ((double) t * 0.5) * 2);
    return (double) t >= 1.0 ? 2f - t : t;
  }

  private void CalculateFractalBounding()
  {
    float num1 = FastNoiseLite.FastAbs(this.mGain);
    float num2 = num1;
    float num3 = 1f;
    for (int index = 1; index < this.mOctaves; ++index)
    {
      num3 += num2;
      num2 *= num1;
    }
    this.mFractalBounding = 1f / num3;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static int Hash(int seed, int xPrimed, int yPrimed)
  {
    return (seed ^ xPrimed ^ yPrimed) * 668265261;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static int Hash(int seed, int xPrimed, int yPrimed, int zPrimed)
  {
    return (seed ^ xPrimed ^ yPrimed ^ zPrimed) * 668265261;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float ValCoord(int seed, int xPrimed, int yPrimed)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
    int num2 = num1 * num1;
    return (float) (num2 ^ num2 << 19) * 4.656613E-10f;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float ValCoord(int seed, int xPrimed, int yPrimed, int zPrimed)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
    int num2 = num1 * num1;
    return (float) (num2 ^ num2 << 19) * 4.656613E-10f;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float GradCoord(int seed, int xPrimed, int yPrimed, float xd, float yd)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
    int index = (num1 ^ num1 >> 15) & 254;
    float num2 = FastNoiseLite.Gradients2D[index];
    float num3 = FastNoiseLite.Gradients2D[index | 1];
    return (float) ((double) xd * (double) num2 + (double) yd * (double) num3);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static float GradCoord(
    int seed,
    int xPrimed,
    int yPrimed,
    int zPrimed,
    float xd,
    float yd,
    float zd)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
    int index = (num1 ^ num1 >> 15) & 252;
    float num2 = FastNoiseLite.Gradients3D[index];
    float num3 = FastNoiseLite.Gradients3D[index | 1];
    float num4 = FastNoiseLite.Gradients3D[index | 2];
    return (float) ((double) xd * (double) num2 + (double) yd * (double) num3 + (double) zd * (double) num4);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static void GradCoordOut(
    int seed,
    int xPrimed,
    int yPrimed,
    out float xo,
    out float yo)
  {
    int index = FastNoiseLite.Hash(seed, xPrimed, yPrimed) & 510;
    xo = FastNoiseLite.RandVecs2D[index];
    yo = FastNoiseLite.RandVecs2D[index | 1];
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static void GradCoordOut(
    int seed,
    int xPrimed,
    int yPrimed,
    int zPrimed,
    out float xo,
    out float yo,
    out float zo)
  {
    int index = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed) & 1020;
    xo = FastNoiseLite.RandVecs3D[index];
    yo = FastNoiseLite.RandVecs3D[index | 1];
    zo = FastNoiseLite.RandVecs3D[index | 2];
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static void GradCoordDual(
    int seed,
    int xPrimed,
    int yPrimed,
    float xd,
    float yd,
    out float xo,
    out float yo)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
    int index1 = num1 & 254;
    int index2 = num1 >> 7 & 510;
    float num2 = FastNoiseLite.Gradients2D[index1];
    float num3 = FastNoiseLite.Gradients2D[index1 | 1];
    float num4 = (float) ((double) xd * (double) num2 + (double) yd * (double) num3);
    float num5 = FastNoiseLite.RandVecs2D[index2];
    float num6 = FastNoiseLite.RandVecs2D[index2 | 1];
    xo = num4 * num5;
    yo = num4 * num6;
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private static void GradCoordDual(
    int seed,
    int xPrimed,
    int yPrimed,
    int zPrimed,
    float xd,
    float yd,
    float zd,
    out float xo,
    out float yo,
    out float zo)
  {
    int num1 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
    int index1 = num1 & 252;
    int index2 = num1 >> 6 & 1020;
    float num2 = FastNoiseLite.Gradients3D[index1];
    float num3 = FastNoiseLite.Gradients3D[index1 | 1];
    float num4 = FastNoiseLite.Gradients3D[index1 | 2];
    float num5 = (float) ((double) xd * (double) num2 + (double) yd * (double) num3 + (double) zd * (double) num4);
    float num6 = FastNoiseLite.RandVecs3D[index2];
    float num7 = FastNoiseLite.RandVecs3D[index2 | 1];
    float num8 = FastNoiseLite.RandVecs3D[index2 | 2];
    xo = num5 * num6;
    yo = num5 * num7;
    zo = num5 * num8;
  }

  private float GenNoiseSingle(int seed, float x, float y)
  {
    switch (this.mNoiseType)
    {
      case FastNoiseLite.NoiseType.OpenSimplex2:
        return this.SingleSimplex(seed, x, y);
      case FastNoiseLite.NoiseType.OpenSimplex2S:
        return this.SingleOpenSimplex2S(seed, x, y);
      case FastNoiseLite.NoiseType.Cellular:
        return this.SingleCellular(seed, x, y);
      case FastNoiseLite.NoiseType.Perlin:
        return this.SinglePerlin(seed, x, y);
      case FastNoiseLite.NoiseType.ValueCubic:
        return this.SingleValueCubic(seed, x, y);
      case FastNoiseLite.NoiseType.Value:
        return this.SingleValue(seed, x, y);
      default:
        return 0.0f;
    }
  }

  private float GenNoiseSingle(int seed, float x, float y, float z)
  {
    switch (this.mNoiseType)
    {
      case FastNoiseLite.NoiseType.OpenSimplex2:
        return this.SingleOpenSimplex2(seed, x, y, z);
      case FastNoiseLite.NoiseType.OpenSimplex2S:
        return this.SingleOpenSimplex2S(seed, x, y, z);
      case FastNoiseLite.NoiseType.Cellular:
        return this.SingleCellular(seed, x, y, z);
      case FastNoiseLite.NoiseType.Perlin:
        return this.SinglePerlin(seed, x, y, z);
      case FastNoiseLite.NoiseType.ValueCubic:
        return this.SingleValueCubic(seed, x, y, z);
      case FastNoiseLite.NoiseType.Value:
        return this.SingleValue(seed, x, y, z);
      default:
        return 0.0f;
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private void TransformNoiseCoordinate(ref float x, ref float y)
  {
    x *= this.mFrequency;
    y *= this.mFrequency;
    switch (this.mNoiseType)
    {
      case FastNoiseLite.NoiseType.OpenSimplex2:
      case FastNoiseLite.NoiseType.OpenSimplex2S:
        float num = (float) (((double) x + (double) y) * 0.366025388240814);
        x += num;
        y += num;
        break;
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private void TransformNoiseCoordinate(ref float x, ref float y, ref float z)
  {
    x *= this.mFrequency;
    y *= this.mFrequency;
    z *= this.mFrequency;
    switch (this.mTransformType3D)
    {
      case FastNoiseLite.TransformType3D.ImproveXYPlanes:
        float num1 = x + y;
        float num2 = num1 * -0.2113249f;
        z *= 0.5773503f;
        x += num2 - z;
        y = y + num2 - z;
        z += num1 * 0.5773503f;
        break;
      case FastNoiseLite.TransformType3D.ImproveXZPlanes:
        float num3 = x + z;
        float num4 = num3 * -0.2113249f;
        y *= 0.5773503f;
        x += num4 - y;
        z += num4 - y;
        y += num3 * 0.5773503f;
        break;
      case FastNoiseLite.TransformType3D.DefaultOpenSimplex2:
        float num5 = (float) (((double) x + (double) y + (double) z) * 0.666666686534882);
        x = num5 - x;
        y = num5 - y;
        z = num5 - z;
        break;
    }
  }

  private void UpdateTransformType3D()
  {
    switch (this.mRotationType3D)
    {
      case FastNoiseLite.RotationType3D.ImproveXYPlanes:
        this.mTransformType3D = FastNoiseLite.TransformType3D.ImproveXYPlanes;
        break;
      case FastNoiseLite.RotationType3D.ImproveXZPlanes:
        this.mTransformType3D = FastNoiseLite.TransformType3D.ImproveXZPlanes;
        break;
      default:
        switch (this.mNoiseType)
        {
          case FastNoiseLite.NoiseType.OpenSimplex2:
          case FastNoiseLite.NoiseType.OpenSimplex2S:
            this.mTransformType3D = FastNoiseLite.TransformType3D.DefaultOpenSimplex2;
            return;
          default:
            this.mTransformType3D = FastNoiseLite.TransformType3D.None;
            return;
        }
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private void TransformDomainWarpCoordinate(ref float x, ref float y)
  {
    switch (this.mDomainWarpType)
    {
      case FastNoiseLite.DomainWarpType.OpenSimplex2:
      case FastNoiseLite.DomainWarpType.OpenSimplex2Reduced:
        float num = (float) (((double) x + (double) y) * 0.366025388240814);
        x += num;
        y += num;
        break;
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  private void TransformDomainWarpCoordinate(ref float x, ref float y, ref float z)
  {
    switch (this.mWarpTransformType3D)
    {
      case FastNoiseLite.TransformType3D.ImproveXYPlanes:
        float num1 = x + y;
        float num2 = num1 * -0.2113249f;
        z *= 0.5773503f;
        x += num2 - z;
        y = y + num2 - z;
        z += num1 * 0.5773503f;
        break;
      case FastNoiseLite.TransformType3D.ImproveXZPlanes:
        float num3 = x + z;
        float num4 = num3 * -0.2113249f;
        y *= 0.5773503f;
        x += num4 - y;
        z += num4 - y;
        y += num3 * 0.5773503f;
        break;
      case FastNoiseLite.TransformType3D.DefaultOpenSimplex2:
        float num5 = (float) (((double) x + (double) y + (double) z) * 0.666666686534882);
        x = num5 - x;
        y = num5 - y;
        z = num5 - z;
        break;
    }
  }

  private void UpdateWarpTransformType3D()
  {
    switch (this.mRotationType3D)
    {
      case FastNoiseLite.RotationType3D.ImproveXYPlanes:
        this.mWarpTransformType3D = FastNoiseLite.TransformType3D.ImproveXYPlanes;
        break;
      case FastNoiseLite.RotationType3D.ImproveXZPlanes:
        this.mWarpTransformType3D = FastNoiseLite.TransformType3D.ImproveXZPlanes;
        break;
      default:
        switch (this.mDomainWarpType)
        {
          case FastNoiseLite.DomainWarpType.OpenSimplex2:
          case FastNoiseLite.DomainWarpType.OpenSimplex2Reduced:
            this.mWarpTransformType3D = FastNoiseLite.TransformType3D.DefaultOpenSimplex2;
            return;
          default:
            this.mWarpTransformType3D = FastNoiseLite.TransformType3D.None;
            return;
        }
    }
  }

  private float GenFractalFBm(float x, float y)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float num3 = this.GenNoiseSingle(mSeed++, x, y);
      num1 += num3 * num2;
      float num4 = num2 * FastNoiseLite.Lerp(1f, FastNoiseLite.FastMin(num3 + 1f, 2f) * 0.5f, this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      num2 = num4 * this.mGain;
    }
    return num1;
  }

  private float GenFractalFBm(float x, float y, float z)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float num3 = this.GenNoiseSingle(mSeed++, x, y, z);
      num1 += num3 * num2;
      float num4 = num2 * FastNoiseLite.Lerp(1f, (float) (((double) num3 + 1.0) * 0.5), this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      z *= this.mLacunarity;
      num2 = num4 * this.mGain;
    }
    return num1;
  }

  private float GenFractalRidged(float x, float y)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float num3 = FastNoiseLite.FastAbs(this.GenNoiseSingle(mSeed++, x, y));
      num1 += (float) ((double) num3 * -2.0 + 1.0) * num2;
      float num4 = num2 * FastNoiseLite.Lerp(1f, 1f - num3, this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      num2 = num4 * this.mGain;
    }
    return num1;
  }

  private float GenFractalRidged(float x, float y, float z)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float num3 = FastNoiseLite.FastAbs(this.GenNoiseSingle(mSeed++, x, y, z));
      num1 += (float) ((double) num3 * -2.0 + 1.0) * num2;
      float num4 = num2 * FastNoiseLite.Lerp(1f, 1f - num3, this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      z *= this.mLacunarity;
      num2 = num4 * this.mGain;
    }
    return num1;
  }

  private float GenFractalPingPong(float x, float y)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float b = FastNoiseLite.PingPong((this.GenNoiseSingle(mSeed++, x, y) + 1f) * this.mPingPongStength);
      num1 += (float) (((double) b - 0.5) * 2.0) * num2;
      float num3 = num2 * FastNoiseLite.Lerp(1f, b, this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      num2 = num3 * this.mGain;
    }
    return num1;
  }

  private float GenFractalPingPong(float x, float y, float z)
  {
    int mSeed = this.mSeed;
    float num1 = 0.0f;
    float num2 = this.mFractalBounding;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float b = FastNoiseLite.PingPong((this.GenNoiseSingle(mSeed++, x, y, z) + 1f) * this.mPingPongStength);
      num1 += (float) (((double) b - 0.5) * 2.0) * num2;
      float num3 = num2 * FastNoiseLite.Lerp(1f, b, this.mWeightedStrength);
      x *= this.mLacunarity;
      y *= this.mLacunarity;
      z *= this.mLacunarity;
      num2 = num3 * this.mGain;
    }
    return num1;
  }

  private float SingleSimplex(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    double num3 = (double) (x - (float) num1);
    float num4 = y - (float) num2;
    float num5 = (float) ((num3 + (double) num4) * 0.211324870586395);
    float xd1 = (float) num3 - num5;
    float yd1 = num4 - num5;
    int xPrimed = num1 * 501125321;
    int yPrimed = num2 * 1136930381;
    float num6 = (float) (0.5 - (double) xd1 * (double) xd1 - (double) yd1 * (double) yd1);
    float num7 = (double) num6 > 0.0 ? (float) ((double) num6 * (double) num6 * ((double) num6 * (double) num6)) * FastNoiseLite.GradCoord(seed, xPrimed, yPrimed, xd1, yd1) : 0.0f;
    float num8 = (float) (3.15470051765442 * (double) num5 + ((double) num6 - 0.666666626930237));
    float num9;
    if ((double) num8 <= 0.0)
    {
      num9 = 0.0f;
    }
    else
    {
      float xd2 = xd1 - 0.5773503f;
      float yd2 = yd1 - 0.5773503f;
      num9 = (float) ((double) num8 * (double) num8 * ((double) num8 * (double) num8)) * FastNoiseLite.GradCoord(seed, xPrimed + 501125321, yPrimed + 1136930381, xd2, yd2);
    }
    float num10;
    if ((double) yd1 > (double) xd1)
    {
      float xd2 = xd1 + 0.2113249f;
      float yd2 = yd1 - 0.7886751f;
      float num11 = (float) (0.5 - (double) xd2 * (double) xd2 - (double) yd2 * (double) yd2);
      num10 = (double) num11 > 0.0 ? (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed, yPrimed + 1136930381, xd2, yd2) : 0.0f;
    }
    else
    {
      float xd2 = xd1 - 0.7886751f;
      float yd2 = yd1 + 0.2113249f;
      float num11 = (float) (0.5 - (double) xd2 * (double) xd2 - (double) yd2 * (double) yd2);
      num10 = (double) num11 > 0.0 ? (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed + 501125321, yPrimed, xd2, yd2) : 0.0f;
    }
    return (float) (((double) num7 + (double) num10 + (double) num9) * 99.8368530273438);
  }

  private float SingleOpenSimplex2(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastRound(x);
    int num2 = FastNoiseLite.FastRound(y);
    int num3 = FastNoiseLite.FastRound(z);
    float xd = x - (float) num1;
    float yd = y - (float) num2;
    float zd = z - (float) num3;
    int num4 = (int) (-1.0 - (double) xd) | 1;
    int num5 = (int) (-1.0 - (double) yd) | 1;
    int num6 = (int) (-1.0 - (double) zd) | 1;
    float num7 = (float) num4 * -xd;
    float num8 = (float) num5 * -yd;
    float num9 = (float) num6 * -zd;
    int xPrimed = num1 * 501125321;
    int yPrimed = num2 * 1136930381;
    int zPrimed = num3 * 1720413743;
    float num10 = 0.0f;
    float num11 = (float) (0.600000023841858 - (double) xd * (double) xd - ((double) yd * (double) yd + (double) zd * (double) zd));
    int num12 = 0;
    while (true)
    {
      if ((double) num11 > 0.0)
        num10 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed, yPrimed, zPrimed, xd, yd, zd);
      if ((double) num7 >= (double) num8 && (double) num7 >= (double) num9)
      {
        float num13 = num11 + num7 + num7;
        if ((double) num13 > 1.0)
        {
          float num14 = num13 - 1f;
          num10 += (float) ((double) num14 * (double) num14 * ((double) num14 * (double) num14)) * FastNoiseLite.GradCoord(seed, xPrimed - num4 * 501125321, yPrimed, zPrimed, xd + (float) num4, yd, zd);
        }
      }
      else if ((double) num8 > (double) num7 && (double) num8 >= (double) num9)
      {
        float num13 = num11 + num8 + num8;
        if ((double) num13 > 1.0)
        {
          float num14 = num13 - 1f;
          num10 += (float) ((double) num14 * (double) num14 * ((double) num14 * (double) num14)) * FastNoiseLite.GradCoord(seed, xPrimed, yPrimed - num5 * 1136930381, zPrimed, xd, yd + (float) num5, zd);
        }
      }
      else
      {
        float num13 = num11 + num9 + num9;
        if ((double) num13 > 1.0)
        {
          float num14 = num13 - 1f;
          num10 += (float) ((double) num14 * (double) num14 * ((double) num14 * (double) num14)) * FastNoiseLite.GradCoord(seed, xPrimed, yPrimed, zPrimed - num6 * 1720413743, xd, yd, zd + (float) num6);
        }
      }
      if (num12 != 1)
      {
        num7 = 0.5f - num7;
        num8 = 0.5f - num8;
        num9 = 0.5f - num9;
        xd = (float) num4 * num7;
        yd = (float) num5 * num8;
        zd = (float) num6 * num9;
        num11 += (float) (0.75 - (double) num7 - ((double) num8 + (double) num9));
        xPrimed += num4 >> 1 & 501125321;
        yPrimed += num5 >> 1 & 1136930381;
        zPrimed += num6 >> 1 & 1720413743;
        num4 = -num4;
        num5 = -num5;
        num6 = -num6;
        seed = ~seed;
        ++num12;
      }
      else
        break;
    }
    return num10 * 32.69428f;
  }

  private float SingleOpenSimplex2S(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    float num3 = x - (float) num1;
    float num4 = y - (float) num2;
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    float num5 = (float) (((double) num3 + (double) num4) * 0.211324870586395);
    float xd1 = num3 - num5;
    float yd1 = num4 - num5;
    float num6 = (float) (0.666666686534882 - (double) xd1 * (double) xd1 - (double) yd1 * (double) yd1);
    float num7 = (float) ((double) num6 * (double) num6 * ((double) num6 * (double) num6)) * FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1, xd1, yd1);
    float num8 = (float) (3.15470051765442 * (double) num5 + ((double) num6 - 0.666666626930237));
    float xd2 = xd1 - 0.5773503f;
    float yd2 = yd1 - 0.5773503f;
    float num9 = num7 + (float) ((double) num8 * (double) num8 * ((double) num8 * (double) num8)) * FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed2, xd2, yd2);
    float num10 = num3 - num4;
    if ((double) num5 > 0.211324870586395)
    {
      if ((double) num3 + (double) num10 > 1.0)
      {
        float xd3 = xd1 - 1.366025f;
        float yd3 = yd1 - 0.3660254f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1 + 1002250642, yPrimed1 + 1136930381, xd3, yd3);
      }
      else
      {
        float xd3 = xd1 + 0.2113249f;
        float yd3 = yd1 - 0.7886751f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1 + 1136930381, xd3, yd3);
      }
      if ((double) num4 - (double) num10 > 1.0)
      {
        float xd3 = xd1 - 0.3660254f;
        float yd3 = yd1 - 1.366025f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1 + 501125321, yPrimed1 - 2021106534, xd3, yd3);
      }
      else
      {
        float xd3 = xd1 - 0.7886751f;
        float yd3 = yd1 + 0.2113249f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1 + 501125321, yPrimed1, xd3, yd3);
      }
    }
    else
    {
      if ((double) num3 + (double) num10 < 0.0)
      {
        float xd3 = xd1 + 0.7886751f;
        float yd3 = yd1 - 0.2113249f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1 - 501125321, yPrimed1, xd3, yd3);
      }
      else
      {
        float xd3 = xd1 - 0.7886751f;
        float yd3 = yd1 + 0.2113249f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1 + 501125321, yPrimed1, xd3, yd3);
      }
      if ((double) num4 < (double) num10)
      {
        float xd3 = xd1 - 0.2113249f;
        float yd3 = yd1 - -0.7886751f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1 - 1136930381, xd3, yd3);
      }
      else
      {
        float xd3 = xd1 + 0.2113249f;
        float yd3 = yd1 - 0.7886751f;
        float num11 = (float) (0.666666686534882 - (double) xd3 * (double) xd3 - (double) yd3 * (double) yd3);
        if ((double) num11 > 0.0)
          num9 += (float) ((double) num11 * (double) num11 * ((double) num11 * (double) num11)) * FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1 + 1136930381, xd3, yd3);
      }
    }
    return num9 * 18.24196f;
  }

  private float SingleOpenSimplex2S(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    int num3 = FastNoiseLite.FastFloor(z);
    float num4 = x - (float) num1;
    float num5 = y - (float) num2;
    float num6 = z - (float) num3;
    int num7 = num1 * 501125321;
    int num8 = num2 * 1136930381;
    int num9 = num3 * 1720413743;
    int seed1 = seed + 1293373;
    int num10 = (int) (-0.5 - (double) num4);
    int num11 = (int) (-0.5 - (double) num5);
    int num12 = (int) (-0.5 - (double) num6);
    float xd1 = num4 + (float) num10;
    float yd1 = num5 + (float) num11;
    float zd1 = num6 + (float) num12;
    float num13 = (float) (0.75 - (double) xd1 * (double) xd1 - (double) yd1 * (double) yd1 - (double) zd1 * (double) zd1);
    float num14 = (float) ((double) num13 * (double) num13 * ((double) num13 * (double) num13)) * FastNoiseLite.GradCoord(seed, num7 + (num10 & 501125321), num8 + (num11 & 1136930381), num9 + (num12 & 1720413743), xd1, yd1, zd1);
    float xd2 = num4 - 0.5f;
    float yd2 = num5 - 0.5f;
    float zd2 = num6 - 0.5f;
    float num15 = (float) (0.75 - (double) xd2 * (double) xd2 - (double) yd2 * (double) yd2 - (double) zd2 * (double) zd2);
    float num16 = num14 + (float) ((double) num15 * (double) num15 * ((double) num15 * (double) num15)) * FastNoiseLite.GradCoord(seed1, num7 + 501125321, num8 + 1136930381, num9 + 1720413743, xd2, yd2, zd2);
    float num17 = (float) ((num10 | 1) << 1) * xd2;
    float num18 = (float) ((num11 | 1) << 1) * yd2;
    float num19 = (float) ((num12 | 1) << 1) * zd2;
    float num20 = (float) ((double) (-2 - (num10 << 2)) * (double) xd2 - 1.0);
    float num21 = (float) ((double) (-2 - (num11 << 2)) * (double) yd2 - 1.0);
    float num22 = (float) ((double) (-2 - (num12 << 2)) * (double) zd2 - 1.0);
    bool flag1 = false;
    float num23 = num17 + num13;
    if ((double) num23 > 0.0)
    {
      float xd3 = xd1 - (float) (num10 | 1);
      float yd3 = yd1;
      float zd3 = zd1;
      num16 += (float) ((double) num23 * (double) num23 * ((double) num23 * (double) num23)) * FastNoiseLite.GradCoord(seed, num7 + (~num10 & 501125321), num8 + (num11 & 1136930381), num9 + (num12 & 1720413743), xd3, yd3, zd3);
    }
    else
    {
      float num24 = num18 + num19 + num13;
      if ((double) num24 > 0.0)
      {
        float xd3 = xd1;
        float yd3 = yd1 - (float) (num11 | 1);
        float zd3 = zd1 - (float) (num12 | 1);
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed, num7 + (num10 & 501125321), num8 + (~num11 & 1136930381), num9 + (~num12 & 1720413743), xd3, yd3, zd3);
      }
      float num25 = num20 + num15;
      if ((double) num25 > 0.0)
      {
        float xd3 = (float) (num10 | 1) + xd2;
        float yd3 = yd2;
        float zd3 = zd2;
        num16 += (float) ((double) num25 * (double) num25 * ((double) num25 * (double) num25)) * FastNoiseLite.GradCoord(seed1, num7 + (num10 & 1002250642), num8 + 1136930381, num9 + 1720413743, xd3, yd3, zd3);
        flag1 = true;
      }
    }
    bool flag2 = false;
    float num26 = num18 + num13;
    if ((double) num26 > 0.0)
    {
      float xd3 = xd1;
      float yd3 = yd1 - (float) (num11 | 1);
      float zd3 = zd1;
      num16 += (float) ((double) num26 * (double) num26 * ((double) num26 * (double) num26)) * FastNoiseLite.GradCoord(seed, num7 + (num10 & 501125321), num8 + (~num11 & 1136930381), num9 + (num12 & 1720413743), xd3, yd3, zd3);
    }
    else
    {
      float num24 = num17 + num19 + num13;
      if ((double) num24 > 0.0)
      {
        float xd3 = xd1 - (float) (num10 | 1);
        float yd3 = yd1;
        float zd3 = zd1 - (float) (num12 | 1);
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed, num7 + (~num10 & 501125321), num8 + (num11 & 1136930381), num9 + (~num12 & 1720413743), xd3, yd3, zd3);
      }
      float num25 = num21 + num15;
      if ((double) num25 > 0.0)
      {
        float xd3 = xd2;
        float yd3 = (float) (num11 | 1) + yd2;
        float zd3 = zd2;
        num16 += (float) ((double) num25 * (double) num25 * ((double) num25 * (double) num25)) * FastNoiseLite.GradCoord(seed1, num7 + 501125321, num8 + (num11 & -2021106534), num9 + 1720413743, xd3, yd3, zd3);
        flag2 = true;
      }
    }
    bool flag3 = false;
    float num27 = num19 + num13;
    if ((double) num27 > 0.0)
    {
      float xd3 = xd1;
      float yd3 = yd1;
      float zd3 = zd1 - (float) (num12 | 1);
      num16 += (float) ((double) num27 * (double) num27 * ((double) num27 * (double) num27)) * FastNoiseLite.GradCoord(seed, num7 + (num10 & 501125321), num8 + (num11 & 1136930381), num9 + (~num12 & 1720413743), xd3, yd3, zd3);
    }
    else
    {
      float num24 = num17 + num18 + num13;
      if ((double) num24 > 0.0)
      {
        float xd3 = xd1 - (float) (num10 | 1);
        float yd3 = yd1 - (float) (num11 | 1);
        float zd3 = zd1;
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed, num7 + (~num10 & 501125321), num8 + (~num11 & 1136930381), num9 + (num12 & 1720413743), xd3, yd3, zd3);
      }
      float num25 = num22 + num15;
      if ((double) num25 > 0.0)
      {
        float xd3 = xd2;
        float yd3 = yd2;
        float zd3 = (float) (num12 | 1) + zd2;
        num16 += (float) ((double) num25 * (double) num25 * ((double) num25 * (double) num25)) * FastNoiseLite.GradCoord(seed1, num7 + 501125321, num8 + 1136930381, num9 + (num12 & -854139810), xd3, yd3, zd3);
        flag3 = true;
      }
    }
    if (!flag1)
    {
      float num24 = num21 + num22 + num15;
      if ((double) num24 > 0.0)
      {
        float xd3 = xd2;
        float yd3 = (float) (num11 | 1) + yd2;
        float zd3 = (float) (num12 | 1) + zd2;
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed1, num7 + 501125321, num8 + (num11 & -2021106534), num9 + (num12 & -854139810), xd3, yd3, zd3);
      }
    }
    if (!flag2)
    {
      float num24 = num20 + num22 + num15;
      if ((double) num24 > 0.0)
      {
        float xd3 = (float) (num10 | 1) + xd2;
        float yd3 = yd2;
        float zd3 = (float) (num12 | 1) + zd2;
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed1, num7 + (num10 & 1002250642), num8 + 1136930381, num9 + (num12 & -854139810), xd3, yd3, zd3);
      }
    }
    if (!flag3)
    {
      float num24 = num20 + num21 + num15;
      if ((double) num24 > 0.0)
      {
        float xd3 = (float) (num10 | 1) + xd2;
        float yd3 = (float) (num11 | 1) + yd2;
        float zd3 = zd2;
        num16 += (float) ((double) num24 * (double) num24 * ((double) num24 * (double) num24)) * FastNoiseLite.GradCoord(seed1, num7 + (num10 & 1002250642), num8 + (num11 & -2021106534), num9 + 1720413743, xd3, yd3, zd3);
      }
    }
    return num16 * 9.046026f;
  }

  private float SingleCellular(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastRound(x);
    int num2 = FastNoiseLite.FastRound(y);
    float num3 = float.MaxValue;
    float num4 = float.MaxValue;
    int num5 = 0;
    float num6 = 0.437016f * this.mCellularJitterModifier;
    int xPrimed = (num1 - 1) * 501125321;
    int num7 = (num2 - 1) * 1136930381;
    switch (this.mCellularDistanceFunction)
    {
      case FastNoiseLite.CellularDistanceFunction.Manhattan:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num7;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int num8 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
            int index3 = num8 & 510;
            float b = FastNoiseLite.FastAbs((float) index1 - x + FastNoiseLite.RandVecs2D[index3] * num6) + FastNoiseLite.FastAbs((float) index2 - y + FastNoiseLite.RandVecs2D[index3 | 1] * num6);
            num4 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num4, b), num3);
            if ((double) b < (double) num3)
            {
              num3 = b;
              num5 = num8;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
      case FastNoiseLite.CellularDistanceFunction.Hybrid:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num7;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int num8 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
            int index3 = num8 & 510;
            float f1 = (float) index1 - x + FastNoiseLite.RandVecs2D[index3] * num6;
            float f2 = (float) index2 - y + FastNoiseLite.RandVecs2D[index3 | 1] * num6;
            float b = (float) ((double) FastNoiseLite.FastAbs(f1) + (double) FastNoiseLite.FastAbs(f2) + ((double) f1 * (double) f1 + (double) f2 * (double) f2));
            num4 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num4, b), num3);
            if ((double) b < (double) num3)
            {
              num3 = b;
              num5 = num8;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
      default:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num7;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int num8 = FastNoiseLite.Hash(seed, xPrimed, yPrimed);
            int index3 = num8 & 510;
            double num9 = (double) ((float) index1 - x) + (double) FastNoiseLite.RandVecs2D[index3] * (double) num6;
            float num10 = (float) index2 - y + FastNoiseLite.RandVecs2D[index3 | 1] * num6;
            float b = (float) (num9 * num9 + (double) num10 * (double) num10);
            num4 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num4, b), num3);
            if ((double) b < (double) num3)
            {
              num3 = b;
              num5 = num8;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
    }
    if (this.mCellularDistanceFunction == FastNoiseLite.CellularDistanceFunction.Euclidean && this.mCellularReturnType >= FastNoiseLite.CellularReturnType.Distance)
    {
      num3 = FastNoiseLite.FastSqrt(num3);
      if (this.mCellularReturnType >= FastNoiseLite.CellularReturnType.Distance2)
        num4 = FastNoiseLite.FastSqrt(num4);
    }
    switch (this.mCellularReturnType)
    {
      case FastNoiseLite.CellularReturnType.CellValue:
        return (float) num5 * 4.656613E-10f;
      case FastNoiseLite.CellularReturnType.Distance:
        return num3 - 1f;
      case FastNoiseLite.CellularReturnType.Distance2:
        return num4 - 1f;
      case FastNoiseLite.CellularReturnType.Distance2Add:
        return (float) (((double) num4 + (double) num3) * 0.5 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Sub:
        return (float) ((double) num4 - (double) num3 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Mul:
        return (float) ((double) num4 * (double) num3 * 0.5 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Div:
        return (float) ((double) num3 / (double) num4 - 1.0);
      default:
        return 0.0f;
    }
  }

  private float SingleCellular(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastRound(x);
    int num2 = FastNoiseLite.FastRound(y);
    int num3 = FastNoiseLite.FastRound(z);
    float num4 = float.MaxValue;
    float num5 = float.MaxValue;
    int num6 = 0;
    float num7 = 0.3961435f * this.mCellularJitterModifier;
    int xPrimed = (num1 - 1) * 501125321;
    int num8 = (num2 - 1) * 1136930381;
    int num9 = (num3 - 1) * 1720413743;
    switch (this.mCellularDistanceFunction)
    {
      case FastNoiseLite.CellularDistanceFunction.Euclidean:
      case FastNoiseLite.CellularDistanceFunction.EuclideanSq:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num8;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int zPrimed = num9;
            for (int index3 = num3 - 1; index3 <= num3 + 1; ++index3)
            {
              int num10 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
              int index4 = num10 & 1020;
              double num11 = (double) ((float) index1 - x) + (double) FastNoiseLite.RandVecs3D[index4] * (double) num7;
              float num12 = (float) index2 - y + FastNoiseLite.RandVecs3D[index4 | 1] * num7;
              float num13 = (float) index3 - z + FastNoiseLite.RandVecs3D[index4 | 2] * num7;
              float b = (float) (num11 * num11 + (double) num12 * (double) num12 + (double) num13 * (double) num13);
              num5 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num5, b), num4);
              if ((double) b < (double) num4)
              {
                num4 = b;
                num6 = num10;
              }
              zPrimed += 1720413743;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
      case FastNoiseLite.CellularDistanceFunction.Manhattan:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num8;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int zPrimed = num9;
            for (int index3 = num3 - 1; index3 <= num3 + 1; ++index3)
            {
              int num10 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
              int index4 = num10 & 1020;
              float b = FastNoiseLite.FastAbs((float) index1 - x + FastNoiseLite.RandVecs3D[index4] * num7) + FastNoiseLite.FastAbs((float) index2 - y + FastNoiseLite.RandVecs3D[index4 | 1] * num7) + FastNoiseLite.FastAbs((float) index3 - z + FastNoiseLite.RandVecs3D[index4 | 2] * num7);
              num5 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num5, b), num4);
              if ((double) b < (double) num4)
              {
                num4 = b;
                num6 = num10;
              }
              zPrimed += 1720413743;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
      case FastNoiseLite.CellularDistanceFunction.Hybrid:
        for (int index1 = num1 - 1; index1 <= num1 + 1; ++index1)
        {
          int yPrimed = num8;
          for (int index2 = num2 - 1; index2 <= num2 + 1; ++index2)
          {
            int zPrimed = num9;
            for (int index3 = num3 - 1; index3 <= num3 + 1; ++index3)
            {
              int num10 = FastNoiseLite.Hash(seed, xPrimed, yPrimed, zPrimed);
              int index4 = num10 & 1020;
              float f1 = (float) index1 - x + FastNoiseLite.RandVecs3D[index4] * num7;
              float f2 = (float) index2 - y + FastNoiseLite.RandVecs3D[index4 | 1] * num7;
              float f3 = (float) index3 - z + FastNoiseLite.RandVecs3D[index4 | 2] * num7;
              float b = (float) ((double) FastNoiseLite.FastAbs(f1) + (double) FastNoiseLite.FastAbs(f2) + (double) FastNoiseLite.FastAbs(f3) + ((double) f1 * (double) f1 + (double) f2 * (double) f2 + (double) f3 * (double) f3));
              num5 = FastNoiseLite.FastMax(FastNoiseLite.FastMin(num5, b), num4);
              if ((double) b < (double) num4)
              {
                num4 = b;
                num6 = num10;
              }
              zPrimed += 1720413743;
            }
            yPrimed += 1136930381;
          }
          xPrimed += 501125321;
        }
        break;
    }
    if (this.mCellularDistanceFunction == FastNoiseLite.CellularDistanceFunction.Euclidean && this.mCellularReturnType >= FastNoiseLite.CellularReturnType.Distance)
    {
      num4 = FastNoiseLite.FastSqrt(num4);
      if (this.mCellularReturnType >= FastNoiseLite.CellularReturnType.Distance2)
        num5 = FastNoiseLite.FastSqrt(num5);
    }
    switch (this.mCellularReturnType)
    {
      case FastNoiseLite.CellularReturnType.CellValue:
        return (float) num6 * 4.656613E-10f;
      case FastNoiseLite.CellularReturnType.Distance:
        return num4 - 1f;
      case FastNoiseLite.CellularReturnType.Distance2:
        return num5 - 1f;
      case FastNoiseLite.CellularReturnType.Distance2Add:
        return (float) (((double) num5 + (double) num4) * 0.5 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Sub:
        return (float) ((double) num5 - (double) num4 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Mul:
        return (float) ((double) num5 * (double) num4 * 0.5 - 1.0);
      case FastNoiseLite.CellularReturnType.Distance2Div:
        return (float) ((double) num4 / (double) num5 - 1.0);
      default:
        return 0.0f;
    }
  }

  private float SinglePerlin(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    float num3 = x - (float) num1;
    float num4 = y - (float) num2;
    float xd = num3 - 1f;
    float yd = num4 - 1f;
    float t1 = FastNoiseLite.InterpQuintic(num3);
    float t2 = FastNoiseLite.InterpQuintic(num4);
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    return FastNoiseLite.Lerp(FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1, num3, num4), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed1, xd, num4), t1), FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed2, num3, yd), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed2, xd, yd), t1), t2) * 1.424769f;
  }

  private float SinglePerlin(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    int num3 = FastNoiseLite.FastFloor(z);
    float num4 = x - (float) num1;
    float num5 = y - (float) num2;
    float num6 = z - (float) num3;
    float xd = num4 - 1f;
    float yd = num5 - 1f;
    float zd = num6 - 1f;
    float t1 = FastNoiseLite.InterpQuintic(num4);
    float t2 = FastNoiseLite.InterpQuintic(num5);
    float t3 = FastNoiseLite.InterpQuintic(num6);
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int zPrimed1 = num3 * 1720413743;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    int zPrimed2 = zPrimed1 + 1720413743;
    double num7 = (double) FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1, zPrimed1, num4, num5, num6), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed1, zPrimed1, xd, num5, num6), t1);
    float num8 = FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed2, zPrimed1, num4, yd, num6), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed2, zPrimed1, xd, yd, num6), t1);
    float a = FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed1, zPrimed2, num4, num5, zd), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed1, zPrimed2, xd, num5, zd), t1);
    float b = FastNoiseLite.Lerp(FastNoiseLite.GradCoord(seed, xPrimed1, yPrimed2, zPrimed2, num4, yd, zd), FastNoiseLite.GradCoord(seed, xPrimed2, yPrimed2, zPrimed2, xd, yd, zd), t1);
    double num9 = (double) num8;
    double num10 = (double) t2;
    return FastNoiseLite.Lerp(FastNoiseLite.Lerp((float) num7, (float) num9, (float) num10), FastNoiseLite.Lerp(a, b, t2), t3) * 0.9649214f;
  }

  private float SingleValueCubic(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    float t1 = x - (float) num1;
    float t2 = y - (float) num2;
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int xPrimed2 = xPrimed1 - 501125321;
    int yPrimed2 = yPrimed1 - 1136930381;
    int xPrimed3 = xPrimed1 + 501125321;
    int yPrimed3 = yPrimed1 + 1136930381;
    int xPrimed4 = xPrimed1 + 1002250642;
    int yPrimed4 = yPrimed1 - 2021106534;
    return FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed2), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed2), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed1), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed1), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed3), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed3), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed3), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed3), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed4), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed4), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed4), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed4), t1), t2) * 0.4444444f;
  }

  private float SingleValueCubic(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    int num3 = FastNoiseLite.FastFloor(z);
    float t1 = x - (float) num1;
    float t2 = y - (float) num2;
    float t3 = z - (float) num3;
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int zPrimed1 = num3 * 1720413743;
    int xPrimed2 = xPrimed1 - 501125321;
    int yPrimed2 = yPrimed1 - 1136930381;
    int zPrimed2 = zPrimed1 - 1720413743;
    int xPrimed3 = xPrimed1 + 501125321;
    int yPrimed3 = yPrimed1 + 1136930381;
    int zPrimed3 = zPrimed1 + 1720413743;
    int xPrimed4 = xPrimed1 + 1002250642;
    int yPrimed4 = yPrimed1 - 2021106534;
    int zPrimed4 = zPrimed1 - 854139810;
    return FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed2, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed2, zPrimed2), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed1, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed1, zPrimed2), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed3, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed3, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed3, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed3, zPrimed2), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed4, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed4, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed4, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed4, zPrimed2), t1), t2), FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed2, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed2, zPrimed1), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed1, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed1, zPrimed1), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed3, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed3, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed3, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed3, zPrimed1), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed4, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed4, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed4, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed4, zPrimed1), t1), t2), FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed2, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed2, zPrimed3), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed1, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed1, zPrimed3), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed3, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed3, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed3, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed3, zPrimed3), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed4, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed4, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed4, zPrimed3), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed4, zPrimed3), t1), t2), FastNoiseLite.CubicLerp(FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed2, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed2, zPrimed4), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed1, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed1, zPrimed4), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed3, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed3, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed3, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed3, zPrimed4), t1), FastNoiseLite.CubicLerp(FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed4, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed4, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed3, yPrimed4, zPrimed4), FastNoiseLite.ValCoord(seed, xPrimed4, yPrimed4, zPrimed4), t1), t2), t3) * 0.2962963f;
  }

  private float SingleValue(int seed, float x, float y)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    float t1 = FastNoiseLite.InterpHermite(x - (float) num1);
    float t2 = FastNoiseLite.InterpHermite(y - (float) num2);
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    return FastNoiseLite.Lerp(FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1), t1), FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2), t1), t2);
  }

  private float SingleValue(int seed, float x, float y, float z)
  {
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    int num3 = FastNoiseLite.FastFloor(z);
    float t1 = FastNoiseLite.InterpHermite(x - (float) num1);
    float t2 = FastNoiseLite.InterpHermite(y - (float) num2);
    float t3 = FastNoiseLite.InterpHermite(z - (float) num3);
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int zPrimed1 = num3 * 1720413743;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    int zPrimed2 = zPrimed1 + 1720413743;
    double num4 = (double) FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed1), t1);
    float num5 = FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed1), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed1), t1);
    float a = FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed1, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed1, zPrimed2), t1);
    float b = FastNoiseLite.Lerp(FastNoiseLite.ValCoord(seed, xPrimed1, yPrimed2, zPrimed2), FastNoiseLite.ValCoord(seed, xPrimed2, yPrimed2, zPrimed2), t1);
    double num6 = (double) num5;
    double num7 = (double) t2;
    return FastNoiseLite.Lerp(FastNoiseLite.Lerp((float) num4, (float) num6, (float) num7), FastNoiseLite.Lerp(a, b, t2), t3);
  }

  private void DoSingleDomainWarp(
    int seed,
    float amp,
    float freq,
    float x,
    float y,
    ref float xr,
    ref float yr)
  {
    switch (this.mDomainWarpType)
    {
      case FastNoiseLite.DomainWarpType.OpenSimplex2:
        this.SingleDomainWarpSimplexGradient(seed, amp * 38.28369f, freq, x, y, ref xr, ref yr, false);
        break;
      case FastNoiseLite.DomainWarpType.OpenSimplex2Reduced:
        this.SingleDomainWarpSimplexGradient(seed, amp * 16f, freq, x, y, ref xr, ref yr, true);
        break;
      case FastNoiseLite.DomainWarpType.BasicGrid:
        this.SingleDomainWarpBasicGrid(seed, amp, freq, x, y, ref xr, ref yr);
        break;
    }
  }

  private void DoSingleDomainWarp(
    int seed,
    float amp,
    float freq,
    float x,
    float y,
    float z,
    ref float xr,
    ref float yr,
    ref float zr)
  {
    switch (this.mDomainWarpType)
    {
      case FastNoiseLite.DomainWarpType.OpenSimplex2:
        this.SingleDomainWarpOpenSimplex2Gradient(seed, amp * 32.69428f, freq, x, y, z, ref xr, ref yr, ref zr, false);
        break;
      case FastNoiseLite.DomainWarpType.OpenSimplex2Reduced:
        this.SingleDomainWarpOpenSimplex2Gradient(seed, amp * 7.716049f, freq, x, y, z, ref xr, ref yr, ref zr, true);
        break;
      case FastNoiseLite.DomainWarpType.BasicGrid:
        this.SingleDomainWarpBasicGrid(seed, amp, freq, x, y, z, ref xr, ref yr, ref zr);
        break;
    }
  }

  private void DomainWarpSingle(ref float x, ref float y)
  {
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    float x1 = x;
    float y1 = y;
    this.TransformDomainWarpCoordinate(ref x1, ref y1);
    this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, ref x, ref y);
  }

  private void DomainWarpSingle(ref float x, ref float y, ref float z)
  {
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    float x1 = x;
    float y1 = y;
    float z1 = z;
    this.TransformDomainWarpCoordinate(ref x1, ref y1, ref z1);
    this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, z1, ref x, ref y, ref z);
  }

  private void DomainWarpFractalProgressive(ref float x, ref float y)
  {
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float x1 = x;
      float y1 = y;
      this.TransformDomainWarpCoordinate(ref x1, ref y1);
      this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, ref x, ref y);
      ++mSeed;
      amp *= this.mGain;
      mFrequency *= this.mLacunarity;
    }
  }

  private void DomainWarpFractalProgressive(ref float x, ref float y, ref float z)
  {
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      float x1 = x;
      float y1 = y;
      float z1 = z;
      this.TransformDomainWarpCoordinate(ref x1, ref y1, ref z1);
      this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, z1, ref x, ref y, ref z);
      ++mSeed;
      amp *= this.mGain;
      mFrequency *= this.mLacunarity;
    }
  }

  private void DomainWarpFractalIndependent(ref float x, ref float y)
  {
    float x1 = x;
    float y1 = y;
    this.TransformDomainWarpCoordinate(ref x1, ref y1);
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, ref x, ref y);
      ++mSeed;
      amp *= this.mGain;
      mFrequency *= this.mLacunarity;
    }
  }

  private void DomainWarpFractalIndependent(ref float x, ref float y, ref float z)
  {
    float x1 = x;
    float y1 = y;
    float z1 = z;
    this.TransformDomainWarpCoordinate(ref x1, ref y1, ref z1);
    int mSeed = this.mSeed;
    float amp = this.mDomainWarpAmp * this.mFractalBounding;
    float mFrequency = this.mFrequency;
    for (int index = 0; index < this.mOctaves; ++index)
    {
      this.DoSingleDomainWarp(mSeed, amp, mFrequency, x1, y1, z1, ref x, ref y, ref z);
      ++mSeed;
      amp *= this.mGain;
      mFrequency *= this.mLacunarity;
    }
  }

  private void SingleDomainWarpBasicGrid(
    int seed,
    float warpAmp,
    float frequency,
    float x,
    float y,
    ref float xr,
    ref float yr)
  {
    double num1 = (double) x * (double) frequency;
    float f = y * frequency;
    int num2 = FastNoiseLite.FastFloor((float) num1);
    int num3 = FastNoiseLite.FastFloor(f);
    float t1 = FastNoiseLite.InterpHermite((float) num1 - (float) num2);
    float t2 = FastNoiseLite.InterpHermite(f - (float) num3);
    int xPrimed1 = num2 * 501125321;
    int yPrimed1 = num3 * 1136930381;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    int index1 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed1) & 510;
    int index2 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed1) & 510;
    float a1 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs2D[index1], FastNoiseLite.RandVecs2D[index2], t1);
    float a2 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs2D[index1 | 1], FastNoiseLite.RandVecs2D[index2 | 1], t1);
    int index3 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed2) & 510;
    int index4 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed2) & 510;
    float b1 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs2D[index3], FastNoiseLite.RandVecs2D[index4], t1);
    float b2 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs2D[index3 | 1], FastNoiseLite.RandVecs2D[index4 | 1], t1);
    xr += FastNoiseLite.Lerp(a1, b1, t2) * warpAmp;
    yr += FastNoiseLite.Lerp(a2, b2, t2) * warpAmp;
  }

  private void SingleDomainWarpBasicGrid(
    int seed,
    float warpAmp,
    float frequency,
    float x,
    float y,
    float z,
    ref float xr,
    ref float yr,
    ref float zr)
  {
    double num1 = (double) x * (double) frequency;
    float f1 = y * frequency;
    float f2 = z * frequency;
    int num2 = FastNoiseLite.FastFloor((float) num1);
    int num3 = FastNoiseLite.FastFloor(f1);
    int num4 = FastNoiseLite.FastFloor(f2);
    float t1 = FastNoiseLite.InterpHermite((float) num1 - (float) num2);
    float t2 = FastNoiseLite.InterpHermite(f1 - (float) num3);
    float t3 = FastNoiseLite.InterpHermite(f2 - (float) num4);
    int xPrimed1 = num2 * 501125321;
    int yPrimed1 = num3 * 1136930381;
    int zPrimed1 = num4 * 1720413743;
    int xPrimed2 = xPrimed1 + 501125321;
    int yPrimed2 = yPrimed1 + 1136930381;
    int zPrimed2 = zPrimed1 + 1720413743;
    int index1 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed1, zPrimed1) & 1020;
    int index2 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed1, zPrimed1) & 1020;
    float a1 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index1], FastNoiseLite.RandVecs3D[index2], t1);
    float a2 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index1 | 1], FastNoiseLite.RandVecs3D[index2 | 1], t1);
    float a3 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index1 | 2], FastNoiseLite.RandVecs3D[index2 | 2], t1);
    int index3 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed2, zPrimed1) & 1020;
    int index4 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed2, zPrimed1) & 1020;
    float b1 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index3], FastNoiseLite.RandVecs3D[index4], t1);
    float b2 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index3 | 1], FastNoiseLite.RandVecs3D[index4 | 1], t1);
    float b3 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index3 | 2], FastNoiseLite.RandVecs3D[index4 | 2], t1);
    float a4 = FastNoiseLite.Lerp(a1, b1, t2);
    float a5 = FastNoiseLite.Lerp(a2, b2, t2);
    float a6 = FastNoiseLite.Lerp(a3, b3, t2);
    int index5 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed1, zPrimed2) & 1020;
    int index6 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed1, zPrimed2) & 1020;
    float a7 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index5], FastNoiseLite.RandVecs3D[index6], t1);
    float a8 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index5 | 1], FastNoiseLite.RandVecs3D[index6 | 1], t1);
    float a9 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index5 | 2], FastNoiseLite.RandVecs3D[index6 | 2], t1);
    int index7 = FastNoiseLite.Hash(seed, xPrimed1, yPrimed2, zPrimed2) & 1020;
    int index8 = FastNoiseLite.Hash(seed, xPrimed2, yPrimed2, zPrimed2) & 1020;
    float b4 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index7], FastNoiseLite.RandVecs3D[index8], t1);
    float b5 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index7 | 1], FastNoiseLite.RandVecs3D[index8 | 1], t1);
    float b6 = FastNoiseLite.Lerp(FastNoiseLite.RandVecs3D[index7 | 2], FastNoiseLite.RandVecs3D[index8 | 2], t1);
    xr += FastNoiseLite.Lerp(a4, FastNoiseLite.Lerp(a7, b4, t2), t3) * warpAmp;
    yr += FastNoiseLite.Lerp(a5, FastNoiseLite.Lerp(a8, b5, t2), t3) * warpAmp;
    zr += FastNoiseLite.Lerp(a6, FastNoiseLite.Lerp(a9, b6, t2), t3) * warpAmp;
  }

  private void SingleDomainWarpSimplexGradient(
    int seed,
    float warpAmp,
    float frequency,
    float x,
    float y,
    ref float xr,
    ref float yr,
    bool outGradOnly)
  {
    x *= frequency;
    y *= frequency;
    int num1 = FastNoiseLite.FastFloor(x);
    int num2 = FastNoiseLite.FastFloor(y);
    double num3 = (double) (x - (float) num1);
    float num4 = y - (float) num2;
    float num5 = (float) ((num3 + (double) num4) * 0.211324870586395);
    float xd1 = (float) num3 - num5;
    float yd1 = num4 - num5;
    int xPrimed = num1 * 501125321;
    int yPrimed = num2 * 1136930381;
    float num6;
    float num7 = num6 = 0.0f;
    float num8 = (float) (0.5 - (double) xd1 * (double) xd1 - (double) yd1 * (double) yd1);
    if ((double) num8 > 0.0)
    {
      float num9 = (float) ((double) num8 * (double) num8 * ((double) num8 * (double) num8));
      float xo;
      float yo;
      if (outGradOnly)
        FastNoiseLite.GradCoordOut(seed, xPrimed, yPrimed, out xo, out yo);
      else
        FastNoiseLite.GradCoordDual(seed, xPrimed, yPrimed, xd1, yd1, out xo, out yo);
      num7 += num9 * xo;
      num6 += num9 * yo;
    }
    float num10 = (float) (3.15470051765442 * (double) num5 + ((double) num8 - 0.666666626930237));
    if ((double) num10 > 0.0)
    {
      float xd2 = xd1 - 0.5773503f;
      float yd2 = yd1 - 0.5773503f;
      float num9 = (float) ((double) num10 * (double) num10 * ((double) num10 * (double) num10));
      float xo;
      float yo;
      if (outGradOnly)
        FastNoiseLite.GradCoordOut(seed, xPrimed + 501125321, yPrimed + 1136930381, out xo, out yo);
      else
        FastNoiseLite.GradCoordDual(seed, xPrimed + 501125321, yPrimed + 1136930381, xd2, yd2, out xo, out yo);
      num7 += num9 * xo;
      num6 += num9 * yo;
    }
    if ((double) yd1 > (double) xd1)
    {
      float xd2 = xd1 + 0.2113249f;
      float yd2 = yd1 - 0.7886751f;
      float num9 = (float) (0.5 - (double) xd2 * (double) xd2 - (double) yd2 * (double) yd2);
      if ((double) num9 > 0.0)
      {
        float num11 = (float) ((double) num9 * (double) num9 * ((double) num9 * (double) num9));
        float xo;
        float yo;
        if (outGradOnly)
          FastNoiseLite.GradCoordOut(seed, xPrimed, yPrimed + 1136930381, out xo, out yo);
        else
          FastNoiseLite.GradCoordDual(seed, xPrimed, yPrimed + 1136930381, xd2, yd2, out xo, out yo);
        num7 += num11 * xo;
        num6 += num11 * yo;
      }
    }
    else
    {
      float xd2 = xd1 - 0.7886751f;
      float yd2 = yd1 + 0.2113249f;
      float num9 = (float) (0.5 - (double) xd2 * (double) xd2 - (double) yd2 * (double) yd2);
      if ((double) num9 > 0.0)
      {
        float num11 = (float) ((double) num9 * (double) num9 * ((double) num9 * (double) num9));
        float xo;
        float yo;
        if (outGradOnly)
          FastNoiseLite.GradCoordOut(seed, xPrimed + 501125321, yPrimed, out xo, out yo);
        else
          FastNoiseLite.GradCoordDual(seed, xPrimed + 501125321, yPrimed, xd2, yd2, out xo, out yo);
        num7 += num11 * xo;
        num6 += num11 * yo;
      }
    }
    xr += num7 * warpAmp;
    yr += num6 * warpAmp;
  }

  private void SingleDomainWarpOpenSimplex2Gradient(
    int seed,
    float warpAmp,
    float frequency,
    float x,
    float y,
    float z,
    ref float xr,
    ref float yr,
    ref float zr,
    bool outGradOnly)
  {
    x *= frequency;
    y *= frequency;
    z *= frequency;
    int num1 = FastNoiseLite.FastRound(x);
    int num2 = FastNoiseLite.FastRound(y);
    int num3 = FastNoiseLite.FastRound(z);
    float xd1 = x - (float) num1;
    float yd1 = y - (float) num2;
    float zd1 = z - (float) num3;
    int num4 = (int) (-(double) xd1 - 1.0) | 1;
    int num5 = (int) (-(double) yd1 - 1.0) | 1;
    int num6 = (int) (-(double) zd1 - 1.0) | 1;
    float num7 = (float) num4 * -xd1;
    float num8 = (float) num5 * -yd1;
    float num9 = (float) num6 * -zd1;
    int xPrimed1 = num1 * 501125321;
    int yPrimed1 = num2 * 1136930381;
    int zPrimed1 = num3 * 1720413743;
    double num10;
    float num11 = (float) (num10 = 0.0);
    float num12 = (float) num10;
    float num13 = (float) num10;
    float num14 = (float) (0.600000023841858 - (double) xd1 * (double) xd1 - ((double) yd1 * (double) yd1 + (double) zd1 * (double) zd1));
    int num15 = 0;
    while (true)
    {
      if ((double) num14 > 0.0)
      {
        float num16 = (float) ((double) num14 * (double) num14 * ((double) num14 * (double) num14));
        float xo;
        float yo;
        float zo;
        if (outGradOnly)
          FastNoiseLite.GradCoordOut(seed, xPrimed1, yPrimed1, zPrimed1, out xo, out yo, out zo);
        else
          FastNoiseLite.GradCoordDual(seed, xPrimed1, yPrimed1, zPrimed1, xd1, yd1, zd1, out xo, out yo, out zo);
        num13 += num16 * xo;
        num12 += num16 * yo;
        num11 += num16 * zo;
      }
      float num17 = num14;
      int xPrimed2 = xPrimed1;
      int yPrimed2 = yPrimed1;
      int zPrimed2 = zPrimed1;
      float xd2 = xd1;
      float yd2 = yd1;
      float zd2 = zd1;
      float num18;
      if ((double) num7 >= (double) num8 && (double) num7 >= (double) num9)
      {
        xd2 += (float) num4;
        num18 = num17 + num7 + num7;
        xPrimed2 -= num4 * 501125321;
      }
      else if ((double) num8 > (double) num7 && (double) num8 >= (double) num9)
      {
        yd2 += (float) num5;
        num18 = num17 + num8 + num8;
        yPrimed2 -= num5 * 1136930381;
      }
      else
      {
        zd2 += (float) num6;
        num18 = num17 + num9 + num9;
        zPrimed2 -= num6 * 1720413743;
      }
      if ((double) num18 > 1.0)
      {
        float num16 = num18 - 1f;
        float num19 = (float) ((double) num16 * (double) num16 * ((double) num16 * (double) num16));
        float xo;
        float yo;
        float zo;
        if (outGradOnly)
          FastNoiseLite.GradCoordOut(seed, xPrimed2, yPrimed2, zPrimed2, out xo, out yo, out zo);
        else
          FastNoiseLite.GradCoordDual(seed, xPrimed2, yPrimed2, zPrimed2, xd2, yd2, zd2, out xo, out yo, out zo);
        num13 += num19 * xo;
        num12 += num19 * yo;
        num11 += num19 * zo;
      }
      if (num15 != 1)
      {
        num7 = 0.5f - num7;
        num8 = 0.5f - num8;
        num9 = 0.5f - num9;
        xd1 = (float) num4 * num7;
        yd1 = (float) num5 * num8;
        zd1 = (float) num6 * num9;
        num14 += (float) (0.75 - (double) num7 - ((double) num8 + (double) num9));
        xPrimed1 += num4 >> 1 & 501125321;
        yPrimed1 += num5 >> 1 & 1136930381;
        zPrimed1 += num6 >> 1 & 1720413743;
        num4 = -num4;
        num5 = -num5;
        num6 = -num6;
        seed += 1293373;
        ++num15;
      }
      else
        break;
    }
    xr += num13 * warpAmp;
    yr += num12 * warpAmp;
    zr += num11 * warpAmp;
  }

  public enum NoiseType
  {
    OpenSimplex2,
    OpenSimplex2S,
    Cellular,
    Perlin,
    ValueCubic,
    Value,
  }

  public enum RotationType3D
  {
    None,
    ImproveXYPlanes,
    ImproveXZPlanes,
  }

  public enum FractalType
  {
    None,
    FBm,
    Ridged,
    PingPong,
    DomainWarpProgressive,
    DomainWarpIndependent,
  }

  public enum CellularDistanceFunction
  {
    Euclidean,
    EuclideanSq,
    Manhattan,
    Hybrid,
  }

  public enum CellularReturnType
  {
    CellValue,
    Distance,
    Distance2,
    Distance2Add,
    Distance2Sub,
    Distance2Mul,
    Distance2Div,
  }

  public enum DomainWarpType
  {
    OpenSimplex2,
    OpenSimplex2Reduced,
    BasicGrid,
  }

  private enum TransformType3D
  {
    None,
    ImproveXYPlanes,
    ImproveXZPlanes,
    DefaultOpenSimplex2,
  }
}
