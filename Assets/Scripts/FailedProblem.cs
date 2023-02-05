using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedProblem : MonoBehaviour
{
    private float time;
    [SerializeField] private Text timerText;
    private float _timeLeft = 0f;
    [SerializeField] GameObject failProblem;

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
            failProblem.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void FailProblems()
    {
        time = Random.Range(10f, 15f);
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
