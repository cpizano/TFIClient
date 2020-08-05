using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject startMenu;
    public InputField userNameField;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("UI Manager Instance already exists! destroying");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        //startMenu.SetActive(false);
        userNameField.interactable = false;

        Client.instance.ConnectToServer();
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
