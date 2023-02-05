using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private int stageOfGrowth = 1;
    [SerializeField] private Sprite[] spriteArray;

    [SerializeField] private float time;
    [SerializeField] private Text timerText;

    private float _timeLeft = 0f;

    private IEnumerator StartTimer()
    {
        while (_timeLeft > 0f)
        {
            _timeLeft-= Time.deltaTime;
            UpdateTimeText();
            yield return null; 
        }
    }
    void ChangeSprite()
    {
        switch (stageOfGrowth)
        {
            case 0:
                time = 5f;
                _timeLeft = time;
                StartCoroutine(StartTimer());
                break;
            case 1:
                spriteRenderer.sprite = spriteArray[0];
                time = 10f;
                _timeLeft = time;
                StartCoroutine(StartTimer());
                break;
            case 2:
                spriteRenderer.sprite = spriteArray[1];
                time = 15f;
                _timeLeft = time;
                StartCoroutine(StartTimer());
                break;
            case 3:
                spriteRenderer.sprite = spriteArray[2];
                time = 0f;
                break;
            default:
                stageOfGrowth = 0;
                Debug.Log("Flower has grown");
                break;
        }
    }

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0f) _timeLeft = 0f;
        float minutes = Mathf.FloorToInt(_timeLeft/ 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
            stageOfGrowth++;
        }
    }
}
