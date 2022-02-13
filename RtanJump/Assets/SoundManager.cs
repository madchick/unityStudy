using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager I;

    public float bgmVolume;
    public float effectVolume;

    private void Awake()
    {
        I = this;
    }
}
