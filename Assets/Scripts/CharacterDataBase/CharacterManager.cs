using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public Text nameText; // UI'deki isim alanı
    private string correctName;
    private string displayedName;
    private bool isFake; // İsmin sahte olup olmadığı

    public void SetCharacter(string correctName, string displayedName, bool isFake)
    {
        this.correctName = correctName;
        this.displayedName = displayedName;
        this.isFake = isFake;

        nameText.text = displayedName; // UI'ye yaz
    }

    public void CheckAnswer(bool playerChoice)
    {
        if ((playerChoice && !isFake) || (!playerChoice && isFake))
        {
            Debug.Log("✅ Doğru karar! Oyun devam ediyor.");
        }
        else
        {
            Debug.Log("❌ Yanlış karar! Oyun bitti.");
            GameOver();
        }

        Destroy(gameObject); // Karakteri sahneden kaldır
        FindObjectOfType<CharacterSpawner>().SpawnCharacter(); // Yeni karakter getir
    }

    void GameOver()
    {
        Debug.Log("Oyun Bitti! Kaybettin.");
        // Burada oyun kaybetme ekranı açılabilir.
    }
}
