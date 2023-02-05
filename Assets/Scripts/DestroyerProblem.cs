using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyerProblem : MonoBehaviour
{
    private float time;
    [SerializeField] private Text timerText;
    private float _timeLeft = 0f;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0f)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
        if (_timeLeft == 0f)
        {
            timerText.text = string.Empty;
            Destroy(gameObject);
        }
    }

    public void DestroyProblem(int tools)
    {
        if (tools == 1 && PlayerPrefs.GetInt("upgradeSpray") == 1)
        {
            time = Random.Range(5f, 10f);
        } else if (tools == 1 && PlayerPrefs.GetInt("upgradeSpray") == 0)
        {
            time = Random.Range(10f, 15f);
        } else if (tools == 2 && PlayerPrefs.GetInt("upgradeAxe") == 1)
        {
            time = Random.Range(5f, 10f);
        } else if (tools == 2 && PlayerPrefs.GetInt("upgradeAxe") == 0)
        {
            time = Random.Range(10f, 15f);
        } else if (tools == 3 && PlayerPrefs.GetInt("upgradeDry") == 1)
        {
            time = Random.Range(5f, 10f);
        } else if (tools == 3 && PlayerPrefs.GetInt("upgradeDry") == 0)
        {
            time = Random.Range(10f, 15f);
        }
        _timeLeft = time;
        StartCoroutine(StartTimer());
        GetComponent<BoxCollider2D>().enabled = false;
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0f) _timeLeft = 0f;
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{00}", seconds);
    }
}
