using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int moneyValueAfterLevel;
    private int moneyValue;

    public void UpdateMoney()
    {
        moneyValueAfterLevel = PlayerPrefs.GetInt("money");
        moneyValue = PlayerPrefs.GetInt("totalMoney");
        moneyValue += moneyValueAfterLevel;
        PlayerPrefs.SetInt("totalMoney", moneyValue);
    }
}
