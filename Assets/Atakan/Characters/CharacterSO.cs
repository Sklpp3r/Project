using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Objects/New Character")]
public class CharacterSO : ScriptableObject
{
    public GameObject pfbChar;
    public Sprite charSprite;
    public string charName;
    public int charAge;
}