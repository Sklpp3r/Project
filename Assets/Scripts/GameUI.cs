using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Button yesButton;
    public Button noButton;
    private CharacterManager currentCharacter;

    void Start()
    {
        yesButton.onClick.AddListener(() => currentCharacter?.CheckAnswer(true));
        noButton.onClick.AddListener(() => currentCharacter?.CheckAnswer(false));
    }

    public void SetCharacter(CharacterManager character)
    {
        currentCharacter = character;
    }
}
