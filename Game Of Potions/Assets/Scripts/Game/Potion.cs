using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private Demand _demand;

    private void Update()
    {
        #if UNITY_EDITOR
                this.transform.position = Input.mousePosition;
        #else
                if(Input.touchCount> 0)
                this.transform.position = Input.GetTouch(0).position;
        #endif
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Demand")
        {
            _demand = collider.GetComponent<Demand>();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Demand")
        {
            _demand = null;
        }
    }

    public void DropPotion(int red, int green, int blue)
    {
        if(_demand != null)
            _demand.OnPotionDrop(red, green, blue);
    }

}
