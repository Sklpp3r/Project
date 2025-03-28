using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public CharacterData[] possibleCharacters; // ScriptableObject veya prefab üzerinden gelecek veri
    public Transform spawnPoint; // Karakterin doğacağı yer
    public CharacterManager characterPrefab; // Karakter prefabı

    void Start()
    {
        SpawnCharacter();
    }

    public void SpawnCharacter()
    {
        // Rastgele karakter seç
        CharacterData selectedCharacter = possibleCharacters[Random.Range(0, possibleCharacters.Length)];

        // %50 ihtimalle ismini yanlış yapalım
        bool isFake = Random.value > 0.5f;
        string displayedName = isFake ? GenerateFakeName(selectedCharacter.correctName) : selectedCharacter.correctName;

        // Yeni karakter nesnesini oluştur
        CharacterManager newCharacter = Instantiate(characterPrefab, spawnPoint.position, Quaternion.identity);
        newCharacter.SetCharacter(selectedCharacter.correctName, displayedName, isFake);
    }

    string GenerateFakeName(string correctName)
    {
        string[] fakeNames = { "Ali", "Mehmet", "Zeynep", "Can", "Elif", "Burak", "Merve" };
        string newFakeName;

        do
        {
            newFakeName = fakeNames[Random.Range(0, fakeNames.Length)];
        } while (newFakeName == correctName); // Aynısını seçmesin

        return newFakeName;
    }
}
