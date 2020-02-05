using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Container : MonoBehaviour
{
    private UIManager m_UIManager;

    public string[] Names;
    public int namesIndex;
    
    private void Start()
    {
        m_UIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    private void Update()
    {
        m_UIManager.Player1.text = Names[0]; /* Currently being worked on */
        m_UIManager.Player2.text = Names[1];
    }
}
