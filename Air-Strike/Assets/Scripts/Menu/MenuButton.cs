using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private GameObject ownPanel;
    
    private static GameObject s_activePanel;

    public void OnClick()
    {
        if (ownPanel.active)
        {
            ownPanel.SetActive(false);
            s_activePanel = null;
        }
        else
        {
            s_activePanel?.SetActive(false);
            ownPanel.SetActive(true);
            s_activePanel = ownPanel;
        }
    }
}
