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
        if (PlayerPrefs.HasKey("NAME"))
        {

            welcomeText.text = $"Welcome back, {PlayerPrefs.GetString("NAME")}";
        }
    }

    public void onClickPlay()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void onClickExit()
    {
        Application.Quit();

    }


}
