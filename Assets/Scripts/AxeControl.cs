using UnityEngine;
using UnityEngine.UI;

public class AxeControl : MonoBehaviour
{
    public bool activationAxeTool;
    [SerializeField] private Sprite[] sprite;
    [SerializeField] private GameObject dryButton;
    [SerializeField] private GameObject pestButton;
    private bool _upgradeAxe;
    void Start()
    {
        activationAxeTool = true;
        if (_upgradeAxe = PlayerPrefs.GetInt("upgradeAxe") == 1)
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
        switch (activationAxeTool)
        {
            case false:
                activationAxeTool = true;
                if (_upgradeAxe = PlayerPrefs.GetInt("upgradeAxe") == 1)
                {
                    GetComponent<Image>().sprite = sprite[2];
                }
                else
                {
                    GetComponent<Image>().sprite = sprite[0];
                }
                pestButton.GetComponent<Button>().interactable = true;
                dryButton.GetComponent<Button>().interactable = true;
                break;
            case true:
                activationAxeTool = false;
                GetComponent<Image>().sprite = sprite[1];
                pestButton.GetComponent<Button>().interactable = false;
                dryButton.GetComponent<Button>().interactable = false;
                break;
        }
    }
}
