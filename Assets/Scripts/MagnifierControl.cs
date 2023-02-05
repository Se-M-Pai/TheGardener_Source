using UnityEngine;
using UnityEngine.UI;

public class MagnifierControl : MonoBehaviour
{
    [SerializeField] private Sprite[] sprite;
    private bool _upgradeMagnifier;

    void Start()
    {
        if (_upgradeMagnifier = PlayerPrefs.GetInt("upgradeMagnifier") == 1)
        {
            GetComponent<Image>().sprite = sprite[1];
        } else
        {
            GetComponent<Image>().sprite = sprite[0];
        }
    }
}
