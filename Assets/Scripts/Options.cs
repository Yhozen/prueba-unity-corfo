using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

    }
    public void onNameInputChange(string name)
    {
        PlayerPrefs.SetString("NAME", name);
    }
    public void onClickBack()
    {
        SceneManager.LoadScene("Init");
    }


    public void setGraphicsLevel(int level)
    {
        QualitySettings.SetQualityLevel(level, true);

    }
    void OnDestroy()
    {
        PlayerPrefs.Save();
    }
}
