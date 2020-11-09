using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public CanvasGroup contentCanvGroup; // main manu canvas group for fading

    public GameObject infoPanel;
    public GameObject loadPanel;

    void Start()
    {
        // deavtivate info panel
        infoPanel.SetActive(false);

        // deactvate load panel
        loadPanel.SetActive(false);

        // let the main menu fade in
        contentCanvGroup.alpha = 0.0f;
        PanelFader panelFader = contentCanvGroup.transform.gameObject.GetComponent<PanelFader>();
        if (panelFader != null) {
            panelFader.mFaded = false;
            panelFader.Fade();
        }
    }

    void Update()
    {
        
    }

    // ================== //
    //  Button functions  //
    // ================== //

    // loads the starting scene
    public void StartNewGame()
    {
        // fade out 
        PanelFader panelFader = contentCanvGroup.transform.gameObject.GetComponent<PanelFader>();
        if (panelFader != null)
        {
            panelFader.mFaded = true;
            panelFader.Fade();
        }

        // load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // show info panel
    public void ShowInfoPanel()
    {
        if(!infoPanel.activeSelf)
        {
            infoPanel.SetActive(true);
        }
    }

    // hide info panel
    public void HideInfoPanel()
    {
        if (infoPanel.activeSelf)
        {
            infoPanel.SetActive(false);
        }
    }

    // show load panel
    public void ShowLoadPanel()
    {
        if (!loadPanel.activeSelf)
        {
            loadPanel.SetActive(true);
        }
    }

    // hide load panel
    public void HideLoadPanel()
    {
        if (loadPanel.activeSelf)
        {
            loadPanel.SetActive(false);
        }
    }

    // exits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
