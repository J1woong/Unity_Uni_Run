using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // OptionMenu ������Ʈ�� UI ��ҵ�
    public GameObject OptionMenu;// OptionMenu�� �����ϴ� ����
    public GameObject MainMenu;
    public Slider audioSlider;      // ����� ���� �����̴�
    public Slider musicSlider;      // ���� ���� ���� �����̴�
    public Button backButton;       // �ڷ� ���� ��ư

    // Start ��ư Ŭ�� �� ���� ��(Main)���� ��ȯ
    public void StartGame()
    {
        SceneManager.LoadScene("Main"); // "Main" ������ ��ȯ
    }

    // Exit ��ư Ŭ�� �� ���ø����̼� ����
    public void ExitGame()
    {
        Application.Quit(); // ���� ����
    }

    // Option ��ư Ŭ�� �� OptionMenu ǥ��
    public void ShowOptions()
    {
        OptionMenu.SetActive(true);  // OptionMenu UI Ȱ��ȭ
        MainMenu.SetActive(false);
    }

    // Back ��ư Ŭ�� �� OptionMenu �����
    public void BackToMenu()
    {
        OptionMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
