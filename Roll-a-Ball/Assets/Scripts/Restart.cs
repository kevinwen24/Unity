﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void Click()
    {
        Debug.Log(1);
        SceneManager.LoadScene(0);
    }
}
