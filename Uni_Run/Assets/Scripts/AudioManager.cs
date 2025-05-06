using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmSource;
    public AudioSource playerSFXSource;

    public Slider musicSlider;
    public Slider sfxSlider;

    void Start()
    {
        // 씬 전환 시 오브젝트가 유지되도록 설정
        DontDestroyOnLoad(gameObject);

        // 슬라이더 값 초기화
        if (musicSlider != null && bgmSource != null)
        {
            musicSlider.value = bgmSource.volume;  // BGM 볼륨 초기화
        }

        if (sfxSlider != null && playerSFXSource != null)
        {
            sfxSlider.value = playerSFXSource.volume; // 점프/죽는 효과음 볼륨 초기화
        }
    }

    // BGM 볼륨 조절
    public void SetBGMVolume(float value)
    {
        if (bgmSource != null)
        {
            bgmSource.volume = value; // BGM 볼륨 설정
        }
    }

    // Player의 효과음 볼륨 조절
    public void SetSFXVolume(float value)
    {
        if (playerSFXSource != null)
        {
            playerSFXSource.volume = value; // 점프/죽는 효과음 볼륨 설정
        }
    }
}
