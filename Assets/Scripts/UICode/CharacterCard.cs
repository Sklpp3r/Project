using UnityEngine;

public class CharacterCard : MonoBehaviour
{
    public CharacterSO characterData;

    public void Init(CharacterSO data)
    {
        characterData = data;
        
    }
}
