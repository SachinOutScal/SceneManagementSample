using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems; 

public class SceneLoader : MonoBehaviour
{
    public void OnLoadSceneButtonPressed()
    {
        var button = EventSystem.current.currentSelectedGameObject;

        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        if (button.name == "BackButton")
        {
            buildIndex--;
        }
        else
        {
            buildIndex++;

        }

        SceneManager.LoadScene(buildIndex, LoadSceneMode.Single);

    }



}
