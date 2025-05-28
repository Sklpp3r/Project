using UnityEngine;
using UnityEngine.EventSystems;

public class UIDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 offset;

    public GameObject cardDetailsPanel;
    public RectTransform readingZone;
    public CanvasGroup cardCanvasGroup; 

    private bool isDetailsVisible = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

       
        if (cardCanvasGroup == null)
            cardCanvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectTransform, eventData.position, canvas.worldCamera, out offset);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, eventData.position, canvas.worldCamera, out localPoint))
        {
            rectTransform.localPosition = localPoint - offset;

            bool isInside = RectTransformUtility.RectangleContainsScreenPoint(readingZone, eventData.position, canvas.worldCamera);

            if (isInside && !isDetailsVisible)
            {
                
                cardCanvasGroup.alpha = 0f;
                cardCanvasGroup.blocksRaycasts = false;

                cardDetailsPanel.SetActive(true);
                cardDetailsPanel.GetComponent<RectTransform>().localPosition = localPoint;
                isDetailsVisible = true;
            }
            else if (!isInside && isDetailsVisible)
            {
                
                cardCanvasGroup.alpha = 1f;
                cardCanvasGroup.blocksRaycasts = true;

                cardDetailsPanel.SetActive(false);
                isDetailsVisible = false;
            }

            
            if (isDetailsVisible)
            {
                cardDetailsPanel.GetComponent<RectTransform>().localPosition = localPoint;
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       
    }
}