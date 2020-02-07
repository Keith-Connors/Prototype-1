using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(UIManager))]
public class GameManager : MonoBehaviour
{
   public UIManager m_UIManager;

   public string Username1, Username2, Username3, Username4;
   public string[] Questions;

   public string Empty = "";
   private void Start()
   {
      m_UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
      
   }

   private void Update()
   {
      Username1 = m_UIManager.Player1.text;
      Username2 = m_UIManager.Player2.text;
      Username3 = m_UIManager.Player3.text;
      Username4 = m_UIManager.Player4.text;
   }
}
