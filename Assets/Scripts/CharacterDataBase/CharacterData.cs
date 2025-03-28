using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public string correctName; // Gerçek doğru isim
    public string displayedName; // Oyuncunun gördüğü isim (yanlış olabilir)
    public bool isFake; // İsim sahte mi? (Eğer sahte ise oyuncu bunu reddetmeli)
}
