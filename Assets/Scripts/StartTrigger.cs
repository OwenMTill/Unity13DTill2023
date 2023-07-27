using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartTrigger : MonoBehaviour
{
    public TMP_Text messageBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerExit(Collider other)
    {
        messageBox.enabled = false;
    }
}
