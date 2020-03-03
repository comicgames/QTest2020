using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmazingMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        float pm_stopspeed = 100.0f;
        float pm_duckScale = 0.25f;
        float pm_swimScale = 0.50f;
        float pm_wadeScale = 0.70f;

        float pm_accelerate = 10.0f;
        float pm_airaccelerate = 1.0f;
        float pm_wateraccelerate = 4.0f;
        float pm_flyaccelerate = 8.0f;

        float pm_friction = 6.0f;
        float pm_waterfriction = 1.0f;
        float pm_flightfriction = 3.0f;
        float pm_spectatorfriction = 5.0f;
        int c_pmove = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
