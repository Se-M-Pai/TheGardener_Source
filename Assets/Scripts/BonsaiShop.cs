using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonsaiShop : MonoBehaviour
{
    private bool _bonsaiNumberOne;
    private bool _bonsaiNumberTwo;
    private bool _bonsaiNumberThree;

    [SerializeField] GameObject[] bonsaiController;
    [SerializeField] GameObject[] checkMark;
    [SerializeField] GameObject[] bonsaiCollector;

    private void Start()
    {
        SwitchIcons();
    }

    public void ByeBonsai(int number)
    {
        switch (number)
        {
            case 4:
                PlayerPrefs.SetInt("bonsaiNumberOne", 1);
                SwitchIcons();
                break;
            case 5:
                PlayerPrefs.SetInt("bonsaiNumberTwo", 1);
                SwitchIcons();
                break;
            case 6:
                PlayerPrefs.SetInt("bonsaiNumberThree", 1);
                SwitchIcons();
                break;
        }
        PlayerPrefs.Save();
    }

    public void SwitchIcons()
    {
        _bonsaiNumberOne = PlayerPrefs.GetInt("bonsaiNumberOne") == 1;
        _bonsaiNumberTwo = PlayerPrefs.GetInt("bonsaiNumberTwo") == 1;
        _bonsaiNumberThree = PlayerPrefs.GetInt("bonsaiNumberThree") == 1;
        ActivationButton();
    }

    public void ActivationButton()
    {
        if (_bonsaiNumberOne)
        {
            bonsaiController[0].GetComponent<Button>().interactable = false;
            checkMark[0].SetActive(true);
            bonsaiCollector[0].SetActive(true);
        }
        else
        {
            bonsaiController[0].GetComponent<Button>().interactable = true;
            checkMark[0].SetActive(false);
            bonsaiCollector[0].SetActive(false);
        }
        if (_bonsaiNumberTwo)
        {
            bonsaiController[1].GetComponent<Button>().interactable = false;
            checkMark[1].SetActive(true);
            bonsaiCollector[1].SetActive(true);
        }
        else
        {
            bonsaiController[1].GetComponent<Button>().interactable = true;
            checkMark[1].SetActive(false);
            bonsaiCollector[1].SetActive(false);
        }
        if (_bonsaiNumberThree)
        {
            bonsaiController[2].GetComponent<Button>().interactable = false;
            checkMark[2].SetActive(true);
            bonsaiCollector[2].SetActive(true);
        }
        else
        {
            bonsaiController[2].GetComponent<Button>().interactable = true;
            checkMark[2].SetActive(false);
            bonsaiCollector[2].SetActive(false);
        }
    }
}
