using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI welcomeText;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        if (PlayerPrefs.HasKey("NAME"))
        {
            string name = PlayerPrefs.GetString("NAME");
            Debug.Log(name);
            welcomeText.text = $"Welcome back, {name}";
        }
    }

    public void onClickPlay()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void onClickOptions()
    {
        SceneManager.LoadScene("Options");

    }
    public void onClickExit()
    {
        Application.Quit();
    }


}
