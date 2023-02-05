using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyController : MonoBehaviour
{
    [SerializeField] GameObject _errorPlane;
    [SerializeField] GameObject _congratsPlane;
    [SerializeField] TextMeshProUGUI _price;
    [SerializeField] GameObject eventSystem;
    private int totalMoney;
    private string priceObject;
    private int priceObjectInt;

    public void ClickToBuy(int number)
    {
        totalMoney = PlayerPrefs.GetInt("totalMoney");
        priceObject = _price.GetComponent<TextMeshProUGUI>().text;
        priceObjectInt = int.Parse(priceObject);
        if (priceObjectInt <= totalMoney)
        {
            totalMoney -= priceObjectInt;
            PlayerPrefs.SetInt("totalMoney", totalMoney);
            PlayerPrefs.Save();
            GetComponent<Button>().interactable = false;
            if (number < 4)
            {
                eventSystem.GetComponent<InventoryController>().UpgradeStuff(number);
            } else
            {
                eventSystem.GetComponent<BonsaiShop>().ByeBonsai(number);
            }
            _congratsPlane.SetActive(true);
        } else
        {
            _errorPlane.SetActive(true);
        }
    }

    public void ClickForMoney()
    {
        PlayerPrefs.SetInt("totalMoney", 1000);
    }
}
