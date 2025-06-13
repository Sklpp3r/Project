using System.Collections.Generic;
using UnityEngine;



public class CharacterGenerator : MonoBehaviour
{
    // bilgilerin geldiği script bu olucak fake olma ihtimalleri de buradan ayarlanacak

    public List<Sprite> fakeSprites; // sahte fotoğraflar için liste 
    public List<string> fakeNames; // sahte isimler için liste 
    // Bunları inspectordan doldurucaz 

    public void SetupCharacter(CharacterSO character) // bilgiler oluşturulması ve sahte olasılığı
    { // Bu kısım olasıkları belirlediğimiz yer %30 ihtimalle sahte bilgi gelicel şekilde ayarladım
        character.DocumentCharSprite = Random.value > 0.7f ? GetRandomSprite(character.charSprite) : character.charSprite;
        character.documentName = Random.value > 0.7f ? GetRandomName(character.documentName) : character.charName;
        character.documentAge = Random.value > 0.7f ? Random.Range(18, 60) : character.charAge;
    }

    private Sprite GetRandomSprite(Sprite exculude) // sahte image çağırma fonksiyonu
    {
        Sprite sprite;
        do
        {
            sprite = fakeSprites[Random.Range(0, fakeSprites.Count)];
        } while (sprite == exculude);
        return sprite;
    }

    private string GetRandomName(string exculude) // sahte isim fonksiyonu
    {
        string name;
        do
        {
            name = fakeNames[Random.Range(0, fakeNames.Count)];
        } while (name == exculude);//exculude gerçek isim olucak böylece aynı olma durumunda while döngüsü bitmeyip devam edicek

        return name;
    }
}