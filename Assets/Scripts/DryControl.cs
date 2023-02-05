using UnityEngine;
using UnityEngine.UI;

public class DryControl : MonoBehaviour
{
    public bool activationDryTool;
    [SerializeField] private Sprite[] sprite;
    [SerializeField] private GameObject pestButton;
    [SerializeField] private GameObject axeButton;
    private bool _upgradeDry;

    void Start()
    {
        activationDryTool = true;
        if (_upgradeDry = PlayerPrefs.GetInt("upgradeDry") == 1)
        {
            GetComponent<Image>().sprite = sprite[2];
        }
        else
        {
            GetComponent<Image>().sprite = sprite[0];
        }
    }

    public void SwitchStateActivation()
    {
        switch (activationDryTool)
        {
            case false:
                activationDryTool = true;
                if (_upgradeDry = PlayerPrefs.GetInt("upgradeDry") == 1)
                {
                    GetComponent<Image>().sprite = sprite[2];
                }
                else
                {
                    GetComponent<Image>().sprite = sprite[0];
                }
                pestButton.GetComponent<Button>().interactable = true;
                axeButton.GetComponent<Button>().interactable = true;
                break;
            case true:
                activationDryTool = false;
                GetComponent<Image>().sprite = sprite[1];
                pestButton.GetComponent<Button>().interactable = false;
                axeButton.GetComponent<Button>().interactable = false;
                break;
        }
    }
}
