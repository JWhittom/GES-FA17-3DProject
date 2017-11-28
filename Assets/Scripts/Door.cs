﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable
{
    private Animator animator;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
	}

    public void DoActivate()
    {
        animator.SetBool("isOpen", true);
    }
}
