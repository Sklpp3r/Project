using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("Data Lists")]
    [Space(2)]
    public List<CharacterSO> listCharacter;
    public List<HouseSO> listHouses;

    [Header("Current Values")]
    [Space(2)]
    public int currentIDNo;
    public List<CharacterSO> listCameChars;

    public static GameManager Instance { get; set; }

    void Awake()
    {
        if (Instance == null) Instance = this;
        else { Destroy(gameObject); }
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

    }

    public void RefuseFuncOnClick()
    {

    }
}