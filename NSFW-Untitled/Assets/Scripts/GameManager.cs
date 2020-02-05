using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(UIManager))]
public class GameManager : MonoBehaviour
{
   public UIManager m_UIManager;

   private void Start()
   {
      m_UIManager = GameObject.Find("GameManager").GetComponent<UIManager>();
      
   }
}
