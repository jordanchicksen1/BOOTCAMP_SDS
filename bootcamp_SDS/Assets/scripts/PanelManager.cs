using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject nextPanel, currentPanel, previousPanel;
   

    public void SelectPanel()
    {
        nextPanel.SetActive(true);
        currentPanel.SetActive(false);
    }

    public void Back()
    {
        previousPanel.SetActive(true);
        currentPanel.SetActive(false);
    }
}
