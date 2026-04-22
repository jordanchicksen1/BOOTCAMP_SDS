using System.Collections.Generic;
using UnityEngine;

public class ScreenSwap : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _screens;
    private bool isOutDoor;
    private bool isJustMe;

    private void Start()
    {
        ShowStartPanel();
    }
    public void ShowStartPanel() 
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[0].SetActive(true);
    }

    public void ShowSChoolOrFun() //Show School or Fun
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[1].SetActive(true);
    }

    public void ShowMeOrFriends()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[2].SetActive(true);
        isJustMe = true;
    }

    public void ActivateActivitiesForMe() 
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[3].SetActive(true);
        isJustMe = true;
    }

    

    public void ActivateActivitiesForFriends()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[3].SetActive(true);
        isJustMe = false;

    }

    public void ActivateOutDoorActivities()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[4].SetActive(true);
        isOutDoor = true;

    }

    public void ActivateInDoorActivities()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[4].SetActive(true);
        isOutDoor = false;
    }

    public void ShowInDoorActivities()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[5].SetActive(true);
    }

    public void ShowOutDoorActivities()
    {
        for (int i = 0; i < _screens.Count; i++)
        {
            _screens[i].SetActive(false);
        }
        _screens[6].SetActive(true);
    }

    public void CheckLocation()
    {
        if (isOutDoor)
        {
            ShowOutDoorActivities();
        }
        else
        {
            ShowInDoorActivities();
        }
    }
}
