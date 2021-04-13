using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEventAnim : MonoBehaviour
{
    [SerializeField] private Animator sword = null;
    [SerializeField] private bool swordPulledOut = false;
    private int animationFrameCounter = 0;
    private bool keyPressed = false;
    private bool animationStarted = false;
    public int reward = 100;
    public GameObject panel;
    Vector3 pos;

    void Update()
    {
        if (sword != null)
        {
            pos = sword.transform.position;

            if (!swordPulledOut && (Input.GetButtonDown("Action") || keyPressed ) && Vector3.Distance(pos, this.transform.position) < 5)
            {
                keyPressed = true;
                animationFrameCounter++;

                if (!animationStarted)
                {
                    sword.Play("pull_out_sword", 0, 0.0f);
                    animationStarted = true;
                }
                
                if (animationFrameCounter >= 115)
                {
                    swordPulledOut = true;
                    Destroy(sword.gameObject);
                    Destroy(panel);
                    PlayerInfo.collectedCandy += reward;
                    keyPressed = false;
                    animationStarted = false;
                }
            }
        }
    }
}
