using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private int problems;
    [SerializeField] GameObject _finishPlane;
    private int _level = 0;

    public void MinusProblem()
    {
        problems--;
        if (problems == 0)
        {
            Finish();
        }
    }

    private void Finish()
    {
        StartCoroutine(Sleep());
        GetComponent<MoneyCollector>().UpdateMoneyValue();

        _level = SceneManager.GetActiveScene().buildIndex;
        switch (_level)
        {
            case 1:
                PlayerPrefs.SetInt("firstLevel", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("secondLevel", 1);
                break;
            case 3:
                PlayerPrefs.SetInt("thirdLevel", 1);
                break;
        }
        PlayerPrefs.Save();
    }

    private IEnumerator Sleep()
    {
        yield return new WaitForSeconds(Random.Range(10, 15));
        _finishPlane.SetActive(true);
    }
}
