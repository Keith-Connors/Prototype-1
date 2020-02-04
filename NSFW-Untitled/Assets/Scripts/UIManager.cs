using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Canvas IntroCanvas, MainScreenCanvas;

    public InputField Player2, Player3, Player4;
    public Button Add_Player2Button, Add_Player3Button;
    public Button Minus_Player2Button, Minus_Player3Button, Minus_Player4Button;

    private void Start()
    {
        IntroCanvas = GameObject.Find("Intro-Canvas").GetComponent<Canvas>();
        MainScreenCanvas = GameObject.Find("MainScreen-Canvas").GetComponent<Canvas>();

        Add_Player2Button = GameObject.Find("Add_Player-2").GetComponent<Button>();
        Add_Player3Button = GameObject.Find("Add_Player-3").GetComponent<Button>();
        
        Minus_Player2Button = GameObject.Find("Minus_Player-2").GetComponent<Button>();
        Minus_Player3Button = GameObject.Find("Minus_Player-3").GetComponent<Button>();
        Minus_Player4Button = GameObject.Find("Minus_Player-4").GetComponent<Button>();

        Player2.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);

        Add_Player2Button.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(false);
        
        Minus_Player2Button.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(false);
        Minus_Player4Button.gameObject.SetActive(false);
    }

    public void AddPlayer2()
    {
        Add_Player2Button.gameObject.SetActive(true);
        Minus_Player2Button.gameObject.SetActive(true);
        Player2.gameObject.SetActive(true);
    }

    public void MinusPlayer2()
    {
        Minus_Player2Button.gameObject.SetActive(false);
        Minus_Player2Button.gameObject.SetActive(false);
        Player2.gameObject.SetActive(false);
        Player2.text = "";
    }
    
    public void AddPlayer3()
    {
        Add_Player3Button.gameObject.SetActive(true);
        Minus_Player3Button.gameObject.SetActive(true);
        Player3.gameObject.SetActive(true);
    }
    public void MinusPlayer3()
    {
        Minus_Player3Button.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player3.text = "";
    }
    
    public void AddPlayer4()
    {
        Minus_Player4Button.gameObject.SetActive(true);
        Player4.gameObject.SetActive(true);
    }
    public void MinusPlayer4()
    {
        Minus_Player4Button.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);
        Player2.text = "";
    }
}
