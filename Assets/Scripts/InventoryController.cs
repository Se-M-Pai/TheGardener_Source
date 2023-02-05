using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    private bool _upgradeAxe;
    private bool _upgradeSpray;
    private bool _upgradeDry;
    private bool _upgradeMagnifier;

    [SerializeField] GameObject[] inventoryUpgrade;
    [SerializeField] GameObject[] checkMark;

    void Start()
    {
        SwitchInventory();
    }

    public void UpgradeStuff(int number)
    {
        switch (number)
        {
            case 0:
                PlayerPrefs.SetInt("upgradeMagnifier", 1);
                SwitchInventory();
                break;
            case 1:
                PlayerPrefs.SetInt("upgradeAxe", 1);
                SwitchInventory();
                break;
            case 2:
                PlayerPrefs.SetInt("upgradeSpray", 1);
                SwitchInventory();
                break;
            case 3:
                PlayerPrefs.SetInt("upgradeDry", 1);
                SwitchInventory();
                break;
        }
        PlayerPrefs.Save();
    }

    public void SwitchInventory()
    {
        _upgradeMagnifier = PlayerPrefs.GetInt("upgradeMagnifier") == 1;
        _upgradeAxe = PlayerPrefs.GetInt("upgradeAxe") == 1;
        _upgradeSpray = PlayerPrefs.GetInt("upgradeSpray") == 1;
        _upgradeDry = PlayerPrefs.GetInt("upgradeDry") == 1;
        ActivationButton();
    }

    public void ActivationButton()
    {
        if (_upgradeMagnifier)
        {
            inventoryUpgrade[0].GetComponent<Button>().interactable = false;
            checkMark[0].SetActive(true);
        } else
        {
            inventoryUpgrade[0].GetComponent<Button>().interactable = true;
            checkMark[0].SetActive(false);
        }
        if (_upgradeAxe)
        {
            inventoryUpgrade[1].GetComponent<Button>().interactable = false;
            checkMark[1].SetActive(true);
        }
        else
        {
            inventoryUpgrade[1].GetComponent<Button>().interactable = true;
            checkMark[1].SetActive(false);
        }
        if (_upgradeSpray)
        {
            inventoryUpgrade[2].GetComponent<Button>().interactable = false;
            checkMark[2].SetActive(true);
        }
        else
        {
            inventoryUpgrade[2].GetComponent<Button>().interactable = true;
            checkMark[2].SetActive(false);
        }
        if (_upgradeDry)
        {
            inventoryUpgrade[3].GetComponent<Button>().interactable = false;
            checkMark[3].SetActive(true);
        }
        else
        {
            inventoryUpgrade[3].GetComponent<Button>().interactable = true;
            checkMark[3].SetActive(false);
        }
    }
}
