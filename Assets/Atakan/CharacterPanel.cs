using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPanel : MonoBehaviour
{
    public CharacterSO characterSO;
    public TextMeshProUGUI txtCharName;
    public TextMeshProUGUI txtCharAge;
    public Image imgChar;

    public void SetCharPanel()
    {
        if (characterSO != null)
        {
            txtCharName.text = characterSO.charName;
            txtCharAge.text = characterSO.charAge.ToString();
            imgChar.sprite = characterSO.charSprite;
        }
    }
}
