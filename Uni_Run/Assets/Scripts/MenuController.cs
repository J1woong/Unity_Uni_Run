using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // OptionMenu 오브젝트와 UI 요소들
    public GameObject OptionMenu;// OptionMenu를 제어하는 변수
    public GameObject MainMenu;
    public Slider audioSlider;      // 오디오 볼륨 슬라이더
    public Slider musicSlider;      // 게임 뮤직 볼륨 슬라이더
    public Button backButton;       // 뒤로 가기 버튼

    // Start 버튼 클릭 시 게임 씬(Main)으로 전환
    public void StartGame()
    {
        SceneManager.LoadScene("Main"); // "Main" 씬으로 전환
    }

    // Exit 버튼 클릭 시 애플리케이션 종료
    public void ExitGame()
    {
        Application.Quit(); // 게임 종료
    }

    // Option 버튼 클릭 시 OptionMenu 표시
    public void ShowOptions()
    {
        OptionMenu.SetActive(true);  // OptionMenu UI 활성화
        MainMenu.SetActive(false);
    }

    // Back 버튼 클릭 시 OptionMenu 숨기기
    public void BackToMenu()
    {
        OptionMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
