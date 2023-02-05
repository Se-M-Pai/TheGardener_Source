using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCollector : MonoBehaviour
{
    private int moneyValueLevel = 0;
    [SerializeField] Text _moneyText;
    [SerializeField] TextMeshProUGUI _moneyTextInShop;
    private int totalMoney;

    public void CongratsProblem()
    {
        moneyValueLevel += 50;
        _moneyText.text = moneyValueLevel.ToString();
    }

    public void UpdateMoneyValue()
    {
        PlayerPrefs.SetInt("money", moneyValueLevel);
        GetComponent<Score>().UpdateMoney();
    }

    public void ShowMoneyInShop()
    {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        _moneyTextInShop.GetComponent<TextMeshProUGUI>().text = totalMoney.ToString();
    }
}
