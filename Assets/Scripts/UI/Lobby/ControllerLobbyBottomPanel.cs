using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerLobbyBottomPanel : MonoBehaviour
{
    [SerializeField]
    private ServiceLobby serviceLobby;

    [SerializeField]
    private ControllerLobbyTabButton tabs;

    private void Awake()
    {
        serviceLobby.OnSelectionChanged += onTabSelectionChanged;
    }

    private void onTabSelectionChanged(Tab tab)
    {
    }
}
