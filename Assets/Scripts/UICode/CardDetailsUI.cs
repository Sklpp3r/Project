using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDetailsUI : MonoBehaviour
{
    public Image imgCharacter;
    public TextMeshProUGUI txtName;
    public TextMeshProUGUI txtAge;
    public TextMeshProUGUI txtGender;
    public TextMeshProUGUI txtBirthday;
    public TextMeshProUGUI txtNationality;

    public void SetCharacterData(CharacterSO character)// Belgede gözükecek bilgileri ayarlıyor
    {
        imgCharacter.sprite = character.charSprite;
        txtName.text = character.charName + ""+ character.charSurname;
        txtGender.text = character.charGender;
        txtBirthday.text = character.charBirthday;
        txtAge.text = character.charAge.ToString();
        txtNationality.text = character.charNationality;
    }
    

}
