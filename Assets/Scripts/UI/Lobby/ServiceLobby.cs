using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tab
{
    None,
    Battle,
    Clan,
    Cards,
    Shop,
    Tournament
}

public class ServiceLobby : MonoBehaviour
{
    public event Action<Tab> OnSelectionChanged;

    private Tab selectedTab = Tab.None;

    public void Start()
    {
        ChangeTab(Tab.Battle);
    }

    public void ChangeTab(Tab tab) 
    {
        if(tab != selectedTab)
        {
            Debug.Log("Changing tab from:" + selectedTab + " to:" + tab);
            selectedTab = tab;
            OnSelectionChanged?.Invoke(selectedTab);
        }
    }
}
