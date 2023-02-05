using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutofillArray : MonoBehaviour
{
    [SerializeField] private GameObject[] problemsArray;
    [SerializeField] private GameObject problemsParent;

    private int _totalProblems = 0;

    void Start()
    {
        _totalProblems = problemsParent.transform.childCount;
        problemsArray = new GameObject[_totalProblems];
        for(int i = 0; i < _totalProblems; i++)
        {
            problemsArray[i] = problemsParent.transform.GetChild(i).gameObject;
        }
    }
}
