using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMechanic : MonoBehaviour, Irobots
{
    public void Bring()
    {
        
    }

    public void Greeting()
    {
        Debug.Log("Привет! Я персональный механик!");
    }

    public void Use()
    {
        Debug.Log("Что вы хотитеб чтобы я починил ?");
    }
}
