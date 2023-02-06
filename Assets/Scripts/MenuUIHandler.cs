using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public InputField InputName;

    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        MenuManager.Instance.LoadScore();
        if(MenuManager.Instance.Score == 0)
        {
            text.text = ("Best Score : : 0");
        }
        else
        {
            text.text = $"Best Score : {MenuManager.Instance.name} : {MenuManager.Instance.Score}";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        MenuManager.Instance.name = InputName.text;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
