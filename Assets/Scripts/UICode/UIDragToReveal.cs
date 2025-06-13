using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragToReveal : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    public RectTransform readingZone;
    public GameObject cardDetails; 

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData) { }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(readingZone, Input.mousePosition, canvas.worldCamera))
        {
           
            cardDetails.SetActive(true);
        }
        else
        {
            
            cardDetails.SetActive(false);
        }
    }
}