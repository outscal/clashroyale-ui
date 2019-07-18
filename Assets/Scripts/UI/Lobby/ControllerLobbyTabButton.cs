using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button), typeof(LayoutElement))]
public class ControllerLobbyTabButton : MonoBehaviour
{
    [SerializeField]
    private Tab tab;

    [SerializeField]
    private ServiceLobby serviceLobby;

    private Button buttonTab;
    private LayoutElement layoutElement;
    private RectTransform rectTransform;

    private bool isSelected;

    private void Awake()
    {
        buttonTab = GetComponent<Button>();
        buttonTab.onClick.AddListener(onClick);

        layoutElement = GetComponent<LayoutElement>();
        rectTransform = GetComponent<RectTransform>();

        serviceLobby.OnSelectionChanged += OnSelectionChanged;
    }

    private void OnSelectionChanged(Tab selectedTab)
    {
        if (tab != selectedTab && isSelected) {
            StartCoroutine(DisableSelection());
        } 
        else if(!isSelected && tab == selectedTab) {
            StartCoroutine(EnableSelection());
        }
    }

    private IEnumerator EnableSelection()
    {
        yield return null;
        isSelected = true;
        layoutElement.preferredWidth = rectTransform.rect.width;
        //Debug.Log("setting preferred width:" + layoutElement.preferredWidth);
    }

    private IEnumerator DisableSelection()
    {
        yield return null;
        isSelected = false;
        layoutElement.preferredWidth = -1f;
    }

    private void onClick()
    {
        serviceLobby.ChangeTab(tab);
    }
}
