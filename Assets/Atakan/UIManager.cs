using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Panel Elements")]
    [Space(2)]
    public RectTransform contentHouse;
    public GameObject pfbCharPanel;

    [Header("UI Elements")]
    [Space(2)]
    public Button btnAccept;
    public Button btnRefuse;
    public Button btnShowData;

    public GameObject panelHouseData;
    bool isOpen;

    public static UIManager Instance { get; set; }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else { Destroy(gameObject); }
    }

    void Start()
    {
        btnShowData.onClick.AddListener(StatusPanel);
        btnAccept.onClick.AddListener(GameManager.Instance.AcceptFuncOnClick);
        btnRefuse.onClick.AddListener(GameManager.Instance.RefuseFuncOnClick);
    }

    public static GameObject PanelBuilder(GameObject pfbObj, RectTransform content)
    {
        GameObject pfbCart = Instantiate(pfbObj, Vector3.zero, Quaternion.identity);
        pfbCart.transform.SetParent(content);
        pfbCart.transform.localScale = Vector3.one;
        pfbCart.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        return pfbCart;
    }

    void StatusPanel()
    {
        if (isOpen)
        {
            isOpen = false;
            CloseHousePanel();
        }
        else
        {
            isOpen = true;
            OpenHousePanel();
        }
    }
    void OpenHousePanel()
    {
        panelHouseData.SetActive(true);
    }
    void CloseHousePanel()
    {
        panelHouseData.SetActive(false);
    }
}