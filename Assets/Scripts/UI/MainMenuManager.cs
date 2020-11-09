using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public CanvasGroup contentCanvGroup;

    void Start()
    {
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

    // exits the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
