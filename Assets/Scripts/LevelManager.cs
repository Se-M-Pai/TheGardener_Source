using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] _levelButton;
    [SerializeField] GameObject finishButton;
    [SerializeField] GameObject[] _ending;

    public void UpdateLevelState()
    {
        if (PlayerPrefs.GetInt("firstLevel") == 1)
        {
            _levelButton[0].SetActive(false);
        } else
        {
            _levelButton[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("secondLevel") == 1)
        {
            _levelButton[1].SetActive(false);
        } else
        {
            _levelButton[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("thirdLevel") == 1)
        {
            _levelButton[2].SetActive(false);
        }
        else
        {
            _levelButton[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("firstLevel") == 1 && PlayerPrefs.GetInt("secondLevel") == 1 && PlayerPrefs.GetInt("thirdLevel") == 1)
        {
            finishButton.SetActive(true);
        } else
        {
            finishButton.SetActive(false);
        }
    }

    public void ChoiceEnding()
    {
        if (PlayerPrefs.GetInt("bonsaiNumberOne") == 1 && PlayerPrefs.GetInt("bonsaiNumberTwo") == 1 && PlayerPrefs.GetInt("bonsaiNumberThree") == 1)
        {
            _ending[1].SetActive(true);
        } else if (PlayerPrefs.GetInt("upgradeMagnifier") == 1 && PlayerPrefs.GetInt("upgradeSpray") == 1 && PlayerPrefs.GetInt("upgradeAxe") == 1 && PlayerPrefs.GetInt("upgradeDry") == 1)
        {
            _ending[0].SetActive(true);
        } else
        {
            _ending[2].SetActive(true);
        }
    }
}
