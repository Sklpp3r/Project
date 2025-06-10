using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDetailsUI : MonoBehaviour
{
    public Image imgCharacter;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtAge;

    public void SetCharacterData(CharacterSO character)
    {
        imgCharacter.sprite = character.charSprite;
        txtName.text = character.name;
        txtAge.text = character.charAge.ToString();
    }
    

}
