using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    // Start ��ư Ŭ�� �� ���� ��(Main)���� ��ȯ
    public void StartGame()
    {
        SceneManager.LoadScene("Main"); // "Main" ������ ��ȯ
    }

    public void EnterHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // Exit ��ư Ŭ�� �� ���ø����̼� ����
    public void ExitGame()
    {
        Application.Quit(); // ���� ����
    }

}
