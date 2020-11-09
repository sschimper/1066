using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonBehaviour : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Button button;
    private TextMeshProUGUI buttonText;
    private Color defaultColor;
    public Color hoveredColor;

    private AudioSource buttonHoverSource;
    private AudioSource buttonClickSource;

    private void Start()
    {
        button = GetComponent<Button>();
        buttonText = button.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        defaultColor = buttonText.color;
        hoveredColor = new Color(218, 165, 32); // golden tone
        // hoveredColor = new Color(225, 0, 0);

        buttonHoverSource = GameObject.Find("Button Hover Sound").GetComponent<AudioSource>();
        buttonClickSource = GameObject.Find("Button Click Sound").GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(buttonText.color != hoveredColor) buttonText.color = hoveredColor;
        buttonHoverSource.PlayOneShot(buttonHoverSource.clip); 
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (buttonText.color != defaultColor) buttonText.color = defaultColor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonClickSource.PlayOneShot(buttonClickSource.clip);
    }
}
