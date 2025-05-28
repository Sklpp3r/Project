using UnityEngine;
using UnityEngine.EventSystems;

public class CardDetailsDrag : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 offset;
    public RectTransform readingzone;
    public GameObject card;               
    private CanvasGroup cardCanvasGroup;   
    public Canvas mainCanvas;
    private bool isDragging = false;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        if (card != null && cardCanvasGroup == null)
        {
            cardCanvasGroup = card.GetComponent<CanvasGroup>();
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            rectTransform, eventData.position, canvas.worldCamera, out offset);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localMousePosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                readingzone, eventData.position, canvas.worldCamera, out localMousePosition))
        {
            rectTransform.localPosition = localMousePosition - offset;
        }
        if (!RectTransformUtility.RectangleContainsScreenPoint(readingzone, Input.mousePosition, mainCanvas.worldCamera))
        {
           
            gameObject.SetActive(false);

            cardCanvasGroup.alpha = 1f;
            cardCanvasGroup.blocksRaycasts = true;
            card.SetActive(true);
        }
    }
}
