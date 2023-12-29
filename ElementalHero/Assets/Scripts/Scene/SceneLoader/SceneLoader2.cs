using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoader2 : MonoBehaviour
{
    void Start() 
    {
        AudioManager.instance.PlayBGM("MainSceneBGM");
    }

    public void StartGame()
    {
        Debug.Log("Start");
        AudioManager.instance.PlaySFX("Touch");
        // 씬 이름으로 전환
        if (SceneManager.GetSceneByName("03. GameScene") != null)
        {
            SceneManager.LoadScene("03. GameScene");
        }
        else
        {
            Debug.LogError("씬을 찾을 수 없습니다.");
        }
    }
}
