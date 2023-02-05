using UnityEngine;
using UnityEngine.UI;

public class PestControl : MonoBehaviour
{
    public bool activationSprayTool;
    [SerializeField] private Sprite[] sprite;
    [SerializeField] private GameObject axeButton;
    [SerializeField] private GameObject dryButton;
    private bool _upgradeSpray;

    void Start()
    {
        activationSprayTool = true;
        if (_upgradeSpray = PlayerPrefs.GetInt("upgradeSpray") == 1)
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
        switch (activationSprayTool)
        {
            case false:
                activationSprayTool = true;
                if (_upgradeSpray = PlayerPrefs.GetInt("upgradeSpray") == 1)
                {
                    GetComponent<Image>().sprite = sprite[2];
                }
                else
                {
                    GetComponent<Image>().sprite = sprite[0];
                }
                axeButton.GetComponent<Button>().interactable = true;
                dryButton.GetComponent<Button>().interactable = true;
                break;
            case true: 
                activationSprayTool = false;
                GetComponent<Image>().sprite = sprite[1];
                axeButton.GetComponent<Button>().interactable = false;
                dryButton.GetComponent<Button>().interactable = false;
                break;
        }
    }
}
