using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "HouseSO", menuName = "Objects/New House")]
public class HouseSO : ScriptableObject
{
    public string houseName;
    public List<CharacterSO> listCharacter;
    public bool isCompleted;
}