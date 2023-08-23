using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCounter : MonoBehaviour
{
    public static MoneyCounter instance;

    public TMP_Text MoneyText;
    private static int CurrentMoney = 0;

    private void Awake() {
        instance = this;
    }
    void Start()
    {   
        MoneyText.text = "$ " + CurrentMoney.ToString();
    }

    public void IncreaseMoney(int money){
        CurrentMoney += money;
        MoneyText.text = "$ " + CurrentMoney.ToString();
    }
}
