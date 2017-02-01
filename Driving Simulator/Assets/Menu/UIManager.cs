using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour {

    public EventSystem ES;
    private GameObject storeSelected;

    void Start()
    {
        storeSelected = ES.firstSelectedGameObject;
    }

    void Update()
    {
        if (ES.currentSelectedGameObject != storeSelected)
        {
            if (ES.currentSelectedGameObject == null)
            {
                ES.SetSelectedGameObject(storeSelected);
            }
            else
            {
                storeSelected = ES.currentSelectedGameObject;
                
            }
        }
    }

    public void LevelOneStart()
    {
        SceneManager.LoadScene("Cars");
    }

    public void LevelTwoStart()
    {
        SceneManager.LoadScene("Cars");
    }

    public void LevelThreeStart()
    {
        SceneManager.LoadScene("Cars");
    }


}
