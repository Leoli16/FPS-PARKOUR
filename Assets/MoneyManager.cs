using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI TxtMoney;
    private ui_man ui_Man;

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No te alcanza");
            return false;
        }
        else
        {
            money += amount;
            ui_Man.updateMoneyUI(money.ToString());
            return true;
        }
    }

    void Start()
    {
        ui_Man = FindObjectOfType<ui_man>();
        UpdateMoney(0);
    }
}
