using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NpcMessage : MonoBehaviour
{

    public GameObject Message;

        public void OnTriggerEnter2D(Collider2D other)
    { 
    if(other.gameObject.CompareTag("Player"))
        {
            Message.SetActive(true);
        }

    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Message.SetActive(false);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
