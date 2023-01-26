using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : Interactable
{
    public int id;
    public bool room2Button;
    public bool room3Button;
    public bool switchButton;   
    public Door targetDoor;

    public MeshRenderer meshRen;
    public DoorButton targetButton;
    public int colorID;
    public Material[] mat;
    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        if (playerInRange)
        {
            if (!Textthing.buttonIDs.Contains(id))
            {
                Textthing.buttonIDs.Add(id);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (room2Button)
                {
                    targetDoor.Unlock();
                }

                if (switchButton)
                {
                    targetButton.colorID++;
                    if (targetButton.colorID > mat.Length - 1)
                    {
                        targetButton.colorID = 0;
                    }
                    meshRen.material = mat[targetButton.colorID];
                }

                if (room3Button && colorID == 4)
                {
                    targetDoor.Unlock();
                }
            }
        } else
        {
            if (Textthing.buttonIDs.Contains(id))
            {
                Textthing.buttonIDs.Remove(id);
            }
        }
    }
}
