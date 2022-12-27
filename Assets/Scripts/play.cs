using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class play : MonoBehaviour
{
    public string SceneName;
    public Button PlayButton;
    //нажатие//
    void Start()
    {
        PlayButton.onClick.AddListener (Task);
    }
     //переход на сцену//
    void Task()
    {
      SceneManager.LoadScene(SceneName);
    }
}
