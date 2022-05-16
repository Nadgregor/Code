using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightMech : MonoBehaviour
{
    [SerializeField]
    private GameObject los;
    private bool isEnabled = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isEnabled)
        {
            los.SetActive(false);
            isEnabled = false;
            Debug.Log(isEnabled);
        }
        else if (Input.GetKeyDown(KeyCode.F) && !isEnabled)
        {
            los.SetActive(true);
            isEnabled = true;
            Debug.Log(isEnabled);
        }
        
    }


}


