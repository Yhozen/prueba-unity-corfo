using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int initialHealth = 100;
    public int maxHealth = 100;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
        
    }

    public int getCurrentHealth() {
        return currentHealth;
    }

    public void onReceiveAttack(int attack) {
        currentHealth -= attack;
        currentHealth = Mathf.Max(0, currentHealth);
    }
    public void onReceiveHeal(int heal) {
        currentHealth += heal;
        currentHealth = Mathf.Min(maxHealth, currentHealth);
    }
}