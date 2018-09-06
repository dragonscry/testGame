using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    private Button menu;
    private Button settings;

    private void Start()
    {
        menu = GameObject.Find("Menu").GetComponent<Button>();
        settings = GameObject.Find("Settings").GetComponent<Button>();

        menu.onClick.AddListener(() =>
        {
            MessageBox.showMassage("Menu");
            Time.timeScale = 0;
        });
        settings.onClick.AddListener(() =>
        {
            MessageBox.showMassage("Settings");
            Time.timeScale = 0;
        });
    }

}
