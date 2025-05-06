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
        // �� ��ȯ �� ������Ʈ�� �����ǵ��� ����
        DontDestroyOnLoad(gameObject);

        // �����̴� �� �ʱ�ȭ
        if (musicSlider != null && bgmSource != null)
        {
            musicSlider.value = bgmSource.volume;  // BGM ���� �ʱ�ȭ
        }

        if (sfxSlider != null && playerSFXSource != null)
        {
            sfxSlider.value = playerSFXSource.volume; // ����/�״� ȿ���� ���� �ʱ�ȭ
        }
    }

    // BGM ���� ����
    public void SetBGMVolume(float value)
    {
        if (bgmSource != null)
        {
            bgmSource.volume = value; // BGM ���� ����
        }
    }

    // Player�� ȿ���� ���� ����
    public void SetSFXVolume(float value)
    {
        if (playerSFXSource != null)
        {
            playerSFXSource.volume = value; // ����/�״� ȿ���� ���� ����
        }
    }
}
