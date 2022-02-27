using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrolllingText : MonoBehaviour
{
    public TextMeshPro TextMeshProComponent;
    public float scrollingSpeed = 10;

    private TextMeshProUGUI m_cloneTextObject;

    private RectTransform m_textRectTransform;
    private string sourceText;
    private string templeText;


    private void Awake()
    {
        m_textRectTransform = TextMeshProComponent.GetComponent<RectTransform>();

        //m_cloneTextObject = Instantiate(TextMeshProComponent) as TextMeshProUGUI;
        RectTransform cloneRectTransform = m_cloneTextObject.GetComponent<RectTransform>();
        cloneRectTransform.anchorMin = new Vector3(1, 0, 0.5f);
        cloneRectTransform.localScale = new Vector3(1, 1, 1);

    }
    void Start()
    {
        float width = TextMeshProComponent.preferredWidth;
        Vector3 startPosition = m_textRectTransform.position;

        float scrollSpeed = 0;

        while (true)
        {
            if (/*TextMeshProComponent.hasChanged*/ true)
            {
                width = TextMeshProComponent.preferredWidth;
                m_cloneTextObject.text = TextMeshProComponent.text;

            }
        }
        
    }

    
    void Update()
    {
        
    }
}
