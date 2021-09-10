using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour
{
    public PhysicsMaterial2D bounce; // creating a material to control bounciness of box

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            transform.localScale = new Vector3(3, 3, 1); // Bigger shape equals less bounce
            bounce.bounciness = 0;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.localScale = new Vector3(1, 1, 1); // Smaller shape equals more bounce
            bounce.bounciness = 2;
        }
    }
}
