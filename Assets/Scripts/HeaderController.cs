﻿using UnityEngine;
using UnityEngine.UI;

public class HeaderController : MonoBehaviour
{
    public GameObject HeaderItem;

    public void AddHeader(string TextValue, ItemType itemType)
    {
        GameObject headerItem = Instantiate(HeaderItem, this.transform);
        headerItem.layer = 5;

        headerItem.transform.position = Vector3.zero;

        Text textComponent = headerItem.GetComponent<Text>();

        textComponent.text = itemType == ItemType.Raw ? TextValue.Replace("_", " ").ToUpper() : TextValue;
        textComponent.alignment = TextAnchor.MiddleCenter;
        textComponent.color = Color.white;
        textComponent.fontSize = 15;
        textComponent.fontStyle = FontStyle.Bold;
        textComponent.horizontalOverflow = HorizontalWrapMode.Overflow;

        GameManager.gameManager.AllItems.Add(headerItem);
    }
}
