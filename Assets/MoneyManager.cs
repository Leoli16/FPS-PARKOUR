using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public TextMeshProUGUI TxtMoney;

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
            TxtMoney.text = "$"+money.ToString();
            return true;
        }
    }

    void Start()
    {
        UpdateMoney(0);
    }
}
