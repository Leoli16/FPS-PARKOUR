using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;
    private ui_man ui_Man;
    // Start is called before the first frame update
    void Start()
    {
        ui_Man = FindObjectOfType<ui_man>();
        UpdateHealth(0);
    }

  
    public void UpdateHealth(int amount)
    {
        if (health + amount <= 0)
        {
            Debug.Log("Game over");
            health = 0;
            ui_Man.updateHealthUI(health.ToString());
            return;
        }
        else
        {
            health += amount;
            ui_Man.updateHealthUI(health.ToString());
        }
    }
}
