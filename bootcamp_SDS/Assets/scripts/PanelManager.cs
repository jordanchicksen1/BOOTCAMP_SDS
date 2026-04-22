using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject nextPanel, currentPanel, previousPanel;
    public GameObject scrollView;
    public GameObject indoorAloneScroll;
    public GameObject outdoorAloneScroll;
    public GameObject indoorNotAloneScroll;
    public GameObject outdoorNotAloneScroll;
    public GameObject indoorNotAlonePanel;
    public GameObject outdoorNotAlonePanel;
    public GameObject indoorAlonePanel;
    public GameObject outdoorAlonePanel;
    public ScrollRect scrollRect;

    public void SelectPanel()
    {
        nextPanel.SetActive(true);
        currentPanel.SetActive(false);
    }

    public void Back()
    {
        previousPanel.SetActive(true);
        currentPanel.SetActive(false);
        scrollView.SetActive(false);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowIndoorAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 1f;
        indoorAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(true);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowOutdoorAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 1f;
        outdoorAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(true);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowIndoorNotAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 1f;
        indoorNotAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(true);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowOutdoorNotAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 1f;
        outdoorNotAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(true);
    }

    public void HideIndoorAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 0f;
        indoorAlonePanel.SetActive(true);
        scrollView.SetActive(false);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void HideOutdoorAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 0f;
        outdoorAlonePanel.SetActive(true);
        scrollView.SetActive(false);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void HideIndoorNotAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 0f;
        indoorNotAlonePanel.SetActive(true);
        scrollView.SetActive(false);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void HideOutdoorNotAloneActivites()
    {
        scrollRect.verticalNormalizedPosition = 0f;
        outdoorNotAlonePanel.SetActive(true);
        scrollView.SetActive(false);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }
}
