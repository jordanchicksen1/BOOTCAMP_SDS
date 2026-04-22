using UnityEngine;

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
        indoorAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(true);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowOutdoorAloneActivites()
    {
        outdoorAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(true);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowIndoorNotAloneActivites()
    {
        indoorNotAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(true);
        outdoorNotAloneScroll.SetActive(false);
    }

    public void ShowOutdoorNotAloneActivites()
    {
        outdoorNotAlonePanel.SetActive(false);
        scrollView.SetActive(true);
        indoorAloneScroll.SetActive(false);
        outdoorAloneScroll.SetActive(false);
        indoorNotAloneScroll.SetActive(false);
        outdoorNotAloneScroll.SetActive(true);
    }
}
