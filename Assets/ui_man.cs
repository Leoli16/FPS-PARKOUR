using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui_man : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;

    public void updateMoneyUI(string money) {
        txtMoney.text = "$" + money;
    }

    public void updateHealthUI(string health)
    {
        txtHealth.text = "HP " + health;
    }
}
