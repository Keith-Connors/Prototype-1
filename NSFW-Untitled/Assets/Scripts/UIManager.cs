using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(GameManager))]
public class UIManager : MonoBehaviour
{
    private GameManager m_GameManager;
    private Container m_Container;
    public Canvas IntroCanvas;//, MainScreenCanvas;

    public InputField Player1, Player2, Player3, Player4;
    public Button Add_Player2Button, Add_Player3Button, Add_Player4Button;
    public Button Minus_Player2Button, Minus_Player3Button, Minus_Player4Button;

    private void Start()
    {
        IntroCanvas = GameObject.Find("Intro-Canvas").GetComponent<Canvas>();
        m_Container = GameObject.Find("Container").GetComponent<Container>();
        
        Player1 = GameObject.Find("Player_Name-1").GetComponent<InputField>();
        Player2 = GameObject.Find("Player_Name-2").GetComponent<InputField>();
        Player3 = GameObject.Find("Player_Name-3").GetComponent<InputField>();
        Player4 = GameObject.Find("Player_Name-4").GetComponent<InputField>();
        
        Add_Player2Button = GameObject.Find("Add_Player-2").GetComponent<Button>();
        Add_Player3Button = GameObject.Find("Add_Player-3").GetComponent<Button>();
        Add_Player4Button = GameObject.Find("Add_Player-4").GetComponent<Button>();
        
        Minus_Player2Button = GameObject.Find("Minus_Player-2").GetComponent<Button>();
        Minus_Player3Button = GameObject.Find("Minus_Player-3").GetComponent<Button>();
        Minus_Player4Button = GameObject.Find("Minus_Player-4").GetComponent<Button>();

        // Player1.gameObject.SetActive(true);
        Player2.gameObject.SetActive(false);
        Player3.gameObject.SetActive(false);
        Player4.gameObject.SetActive(false);

        //Add_Player2Button.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(false);
        Add_Player4Button.gameObject.SetActive(false);
        
        Minus_Player2Button.gameObject.SetActive(false);
        Minus_Player3Button.gameObject.SetActive(false);
        Minus_Player4Button.gameObject.SetActive(false);
    }


    public void AddPlayer2()
    {
        Add_Player3Button.gameObject.SetActive(true);
        Minus_Player2Button.gameObject.SetActive(true);
        Player2.gameObject.SetActive(true);
    }

    public void MinusPlayer2()
    {
        Player2.gameObject.SetActive(false);
        Add_Player3Button.gameObject.SetActive(false);
        Player2.text = "";
        Minus_Player2Button.gameObject.SetActive(false);

    }
    
    public void AddPlayer3()
    {
        Add_Player4Button.gameObject.SetActive(true);
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


    private void Update()
    {
        
    }
}
