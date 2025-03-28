using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HousePanel : MonoBehaviour
{
    public Button btnShowHouse;
    public TextMeshProUGUI txtHouseName;

    private void Start()
    {
        btnShowHouse.onClick.AddListener(ShowHouseOnClick);
    }

    public void SetHousePanel()
    {
        GameManager.Instance.SetCameCharList();
        
        if (GameManager.Instance.currentIDNo < GameManager.Instance.listHouses.Count)
        {
            HouseSO currentHouseSO = GameManager.Instance.listHouses[GameManager.Instance.currentIDNo];

            if (currentHouseSO != null)
            {
                txtHouseName.text = currentHouseSO.houseName;

                foreach (Transform child in UIManager.Instance.contentHouse.transform)
                {
                    Destroy(child.gameObject);
                }

                foreach (var character in currentHouseSO.listCharacter)
                {
                    GameObject objCharPnl = UIManager.PanelBuilder(UIManager.Instance.pfbCharPanel, UIManager.Instance.contentHouse);
                    if (objCharPnl.TryGetComponent<CharacterPanel>(out var panel))
                    {
                        panel.characterSO = character;
                        panel.SetCharPanel();
                    }
                }
            }
        }
        else
        {
            Debug.Log("Ev listesinin countundan fazla bir indeks denendi.");
        }
    }

    public void ShowHouseOnClick()
    {
        SetHousePanel();
    }
}
