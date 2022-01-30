using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI points;
    public PointsManager pointsManager;
    public HealthManager healthManager;
    public Image healthIndicator;

    void Start()
    {
        healthText.text = "test";
        points.text = "ala";
    }

    // Update is called once per frame
    void Update()
    {
        points.text = $"Points: {pointsManager.getCurrentPoints()}";
        healthText.text = $"Health: {healthManager.getCurrentHealth()}";
        healthIndicator.fillAmount = healthManager.getCurrentHealhPercentage() / 100;
    }
}
