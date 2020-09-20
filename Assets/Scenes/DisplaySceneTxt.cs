using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class DisplaySceneTxt : MonoBehaviour
{
    [SerializeField]
    private Text displaySceneName;
    void Start()
    {
        displaySceneName.text = SceneManager.GetActiveScene().name;

    }
}
