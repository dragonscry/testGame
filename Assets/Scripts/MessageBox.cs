using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour {

    private static MessageBox instance;

    public GameObject Template;

    private void Awake()
    {
        instance = this;
    }

    public static void showMassage(string text)
    {
        GameObject messageBox = Instantiate(instance.Template);

        Transform panel = messageBox.transform.Find("Panel");

        Text messageBoxText = panel.Find("Text").GetComponent<Text>();
        messageBoxText.text = text;

        Button resume = panel.Find("Resume").GetComponent<Button>();

        resume.onClick.AddListener(() =>
        {
            Destroy(messageBox);
            Time.timeScale = 1;
        });
    }
}
