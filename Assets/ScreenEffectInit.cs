using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ScreenEffectInit : MonoBehaviour
{

	void Awake ()
    {
        VRTK_SharedMethods.AddCameraFade();
    }
    //实现黑屏
    //VRTK_SDK_Bridge.HeadsetFade(Color.black, 0f);
    //VRTK_SDK_Bridge.HeadsetFade(Color.clear, 4f);
}
