﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;
using UnityEngine.AI;
public class Yun2Talk2 : MonoBehaviour
{
    CharacterController controller;
    Animator animationYun;
    private int count = 0;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //retrieve the animations set for the player.
        animationYun = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<levelcontroller2>().alreadyPlayedMilkAudio == true)
        {
            animationYun.SetInteger("YunTalk", 1);
            count = 1;
        }
        else
        {
            animationYun.SetInteger("YunTalk", 0);
            count = 0;
        }
    }
}
