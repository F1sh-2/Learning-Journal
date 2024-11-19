using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcObjective : MonoBehaviour
{
    bool player_detection = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if(player_detection && Input.GetKeyDown(KeyCode.F))
        {
            print ("Dialogue Started");
        }
    }
      private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerBody")
        {
            player_detection = true;
        }
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }
}