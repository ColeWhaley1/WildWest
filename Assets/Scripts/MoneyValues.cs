using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyValues : MonoBehaviour
{
    [SerializeField] private int RandomMinValue;
    [SerializeField] private int RandomMaxValue;
    private int Value;

    private void Start() {
        Value = Random.Range(RandomMinValue, RandomMaxValue);
    }

    public int getValue(){
        return Value;
    }
}
