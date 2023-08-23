using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollect : MonoBehaviour
{
    public GameObject parent;
    private int AmountToAddToTotalMoney;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            AmountToAddToTotalMoney = parent.gameObject.GetComponent<MoneyValues>().getValue(); //gets value of coin/moneybag

            if(AmountToAddToTotalMoney != null){
                MoneyCounter.instance.IncreaseMoney(AmountToAddToTotalMoney); //increases instance of money counter and displays amount
            }

            Destroy(parent);
        }
    }
}
