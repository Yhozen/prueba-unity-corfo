using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TextObject;
    public TextMeshProUGUI points;
    public PointsManager pointsManager;

    void Start()
    {
        TextObject.text = "test";
        points.text = "ala";
    }

    // Update is called once per frame
    void Update()
    {
        points.text = $"Points: {pointsManager.getCurrentPoints()}";
    }
}
