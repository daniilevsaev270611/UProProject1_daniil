using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
        }

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

         
                
    }
}
