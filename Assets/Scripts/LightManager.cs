using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Experimental.Rendering.Universal;

public class LightManager : MonoBehaviour
{
    [SerializeField] Light2D globalLight;
    [SerializeField] int freezeEveryNSeconds = 10;
    [SerializeField] int freezeDuration = 3;
    [SerializeField] Animator m_globalLightAnimator;

    // Start is called before the first frame update
    void Start()
    {
        globalLight.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameStateManager.timerSeconds % freezeEveryNSeconds == 0 && GameStateManager.timerSeconds != 0)
        {
            if (GameStateManager.freezePlayer == false)
            {
                m_globalLightAnimator.SetTrigger("Start");
                //globalLight.intensity = 1;
                GameStateManager.freezePlayer = true;
            }
        }
        else if (GameStateManager.timerSeconds % freezeDuration == 0 && GameStateManager.timerSeconds != 0)
        {
            //globalLight.intensity = 0;
            GameStateManager.freezePlayer = false;
        }
    }
}
