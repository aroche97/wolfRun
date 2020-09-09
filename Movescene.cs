﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movescene : MonoBehaviour
{
    [SerializeField] private string winMenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            SceneManager.LoadScene(winMenu);
        }
    }
}