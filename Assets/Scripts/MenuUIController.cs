﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIController : MonoBehaviour
{
    private bool _pressed;

    public void PressPlay()
    {
        if (_pressed) return;

        _pressed = true;
        GameManager.Instance.EndLevel();
    }
}
