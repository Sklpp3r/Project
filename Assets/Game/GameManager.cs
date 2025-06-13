using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [Header("Data Lists")]
    [Space(2)]
    public List<CharacterSO> listCharacter;
    public List<HouseSO> listHouses;

    [Header("Current Values")]
    [Space(2)]
    public RectTransform imgChar;
    public int currentIDNo;
    public int seqNo;

    public List<CharacterSO> listCameChars;

    public Button btnShowHouse;
    public TextMeshProUGUI txtHouseName;
   

    public static GameManager Instance { get; set; }

    public float charSpeed = 2f;
    public Vector3 charStartPos;
    public Vector3 charEndPos;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else { Destroy(gameObject); }
    }

    private void Start()
    {
        SetHousePanel();
       
        StartCoroutine(MoveImage(-1400, 0));
    }

    public void SetHousePanel()
    {
        SetCameCharList();

        if (currentIDNo < listHouses.Count)
        {
            HouseSO currentHouseSO = listHouses[currentIDNo];

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
    public void SetCameCharList()
    {
        int listCount = Random.Range(0, listCharacter.Count + 1);

        HashSet<CharacterSO> addedIndices = new();

        while (addedIndices.Count < listCount)
        {
            CharacterSO getChar = listCharacter[Random.Range(0, listCharacter.Count)];

            if (!addedIndices.Contains(getChar))
            {
                addedIndices.Add(getChar);
            }
        }
        listCameChars = new List<CharacterSO>(addedIndices);
    }



    public void AcceptFuncOnClick()
    {
        if (seqNo != -1)
        {
            StartCoroutine(MoveImage(0, 1400));

            imgChar.GetComponent<Image>().sprite = listCameChars[seqNo].charSprite;
        }
    }
    public void RefuseFuncOnClick()
    {
        if (seqNo != -1)
        {
            StartCoroutine(MoveImage(0, -1400));

            imgChar.GetComponent<Image>().sprite = listCameChars[seqNo].charSprite;
        }
    }

    public IEnumerator MoveImage(float start, float end)
    {
        Vector2 startPos = new(start, imgChar.anchoredPosition.y);
        Vector2 endPos = new(end, imgChar.anchoredPosition.y);
        float duration = 3f;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            imgChar.anchoredPosition = Vector2.Lerp(startPos, endPos, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        imgChar.anchoredPosition = endPos;
    }
}