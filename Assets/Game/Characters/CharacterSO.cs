using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Objects/New Character")]
public class CharacterSO : ScriptableObject
{
    // gerçek bilgi olarak bunları kullanıcaz
    public GameObject pfbChar;
    public Sprite charSprite;
    public string charName;
    public int charAge;
    public string charSurname;
    public string charGender;
    public string charBirthday;
    public string charNationality;
    
// bunlarda dökümanda gözükecek bilgiler olucak sahte olma ihtimallerini de ekleyeceğiz
    public Sprite DocumentCharSprite;
    public string documentName;
    public int documentAge;
    
    
}