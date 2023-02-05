using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProblemObject : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject _eventSystem;
    [SerializeField] GameObject audioSource;

    private void Start()
    {
        AddPhysics2DRaycaster();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject goSpray = GameObject.Find("insect spray button");
        PestControl pestControl = goSpray.GetComponent<PestControl>();
        bool _activationSprayTool = pestControl.activationSprayTool;

        GameObject goAxe = GameObject.Find("axe button");
        AxeControl axeControl = goAxe.GetComponent<AxeControl>();
        bool _activationAxeTool = axeControl.activationAxeTool;

        GameObject goDry = GameObject.Find("dry button");
        DryControl dryControl = goDry.GetComponent<DryControl>();
        bool _activationDryTool = dryControl.activationDryTool;


        if (eventData.pointerCurrentRaycast.gameObject.tag == "Pest" && _activationSprayTool == false)
        {
            _eventSystem.GetComponent<MoneyCollector>().CongratsProblem();
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<DestroyerProblem>().DestroyProblem(1);
        } else if (eventData.pointerCurrentRaycast.gameObject.tag == "Pest" && (_activationAxeTool == false || _activationDryTool == false))
        {
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<FailedProblem>().FailProblems();
        }

        if (eventData.pointerCurrentRaycast.gameObject.tag == "Snag" && _activationAxeTool == false)
        {
            _eventSystem.GetComponent<MoneyCollector>().CongratsProblem();
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<DestroyerProblem>().DestroyProblem(2);
        } else if (eventData.pointerCurrentRaycast.gameObject.tag == "Snag" && (_activationSprayTool == false || _activationDryTool == false))
        {
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<FailedProblem>().FailProblems();
        }

        if (eventData.pointerCurrentRaycast.gameObject.tag == "Dryness" && _activationDryTool == false)
        {
            _eventSystem.GetComponent<MoneyCollector>().CongratsProblem();
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<DestroyerProblem>().DestroyProblem(3);
        } else if (eventData.pointerCurrentRaycast.gameObject.tag == "Dryness" && (_activationAxeTool == false || _activationSprayTool == false))
        {
            _eventSystem.GetComponent<FinishLevel>().MinusProblem();
            GetComponent<FailedProblem>().FailProblems();
        }
        audioSource.GetComponent<AudioSource>().Play();
    }

    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }
}