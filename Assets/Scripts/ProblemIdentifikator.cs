using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProblemIdentifikator: MonoBehaviour
{
    private float time;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Text timerText;
    [SerializeField] GameObject problems;
    private bool _upgradeMagnifier;
    private float _timeLeft = 0f;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0f)
        {
            _timeLeft -= Time.deltaTime;
            UpdateTimeText();
            yield return null;
        }
        if(_timeLeft == 0f) 
        {
            timerText.text = string.Empty;
            problems.SetActive(true);
            spriteRenderer.enabled = false;
        }
    }

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    public void OnClick()
    {

        if (_upgradeMagnifier = PlayerPrefs.GetInt("upgradeMagnifier") == 1)
        {
            time = Random.Range(5f, 10f);
        } else
        {
            time = Random.Range(10f, 15f);
        }
        _timeLeft = time;
        StartCoroutine(StartTimer());
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0f) _timeLeft = 0f;
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{00}", seconds);
    }
}
