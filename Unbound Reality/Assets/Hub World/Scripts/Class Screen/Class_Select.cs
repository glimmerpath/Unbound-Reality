﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Class_Select : MonoBehaviour
{
    public BaseClass Warrior = new BaseClass("Warrior", 6, 15, 3, 6);
    public BaseClass Mage = new BaseClass("Mage", 6, 3, 15, 6);
    public BaseClass Rouge = new BaseClass("Rouge", 15, 6, 3, 6);
    public BaseClass Archer = new BaseClass("Archer", 8, 6, 4, 15);
    public Text Displayinfo;

    public void Start()
    {
        Displayinfo.enabled = false;
    }
    public void PointerEnter(Button btn)
    {
        Displayinfo.enabled = true;
        if (btn.name == "WarriorButton")
        {
            Displayinfo.text = "Name: " + Warrior.ClassName() + "\nSpeed: " + Warrior.Speed() + "\nStrength: " + Warrior.Strength() + "\nMagic: " + Warrior.MagicStrength() + "\nCritical: " + Warrior.Critical(); 
        }
        else if (btn.name == "MageButton")
        {
            Displayinfo.text = "Name: " + Mage.ClassName() + "\nSpeed: " + Mage.Speed() + "\nStrength: " + Mage.Strength() + "\nMagic: " + Mage.MagicStrength() + "\nCritical: " + Mage.Critical();
        }
        else if (btn.name == "RougeButton")
        {
            Displayinfo.text = "Name: " + Rouge.ClassName() + "\nSpeed: " + Rouge.Speed() + "\nStrength: " + Rouge.Strength() + "\nMagic: " + Rouge.MagicStrength() + "\nCritical: " + Rouge.Critical();
        }
        else if (btn.name == "ArcherButton")
        {
            Displayinfo.text = "Name: " + Archer.ClassName() + "\nSpeed: " + Archer.Speed() + "\nStrength: " + Archer.Strength() + "\nMagic: " + Archer.MagicStrength() + "\nCritical: " + Archer.Critical();
        }
    }
    public void PointerExit()
    {
        Displayinfo.enabled = false;
    }
        public void PlayGame(Button btn)
    {
        float getMove = NonVRCharacterController.moveSpeed;
        SceneManager.LoadScene("Hub World");

        if (btn.name == "WarriorButton")
        {
            float move = Warrior.Speed();
            NonVRCharacterController.moveSpeed = move;
        }
        else if (btn.name == "MageButton")
        {
            float move = Mage.Speed();
            NonVRCharacterController.moveSpeed = move;
        }
        Debug.Log(btn.name);
    }
}
