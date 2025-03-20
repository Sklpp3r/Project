using UnityEngine;

public class InfoCube : MonoBehaviour
{
    public GameObject infoCanvas; 
    public GameObject panel; 

    void OnMouseDown()
    {
        Debug.Log("Küpe tıklandı!");
        if (infoCanvas != null)
        {
            infoCanvas.SetActive(true); 
            if (panel != null)
            {
                panel.SetActive(true);
                Debug.Log("Panel açıldı!");
            }
        }
    }
}
