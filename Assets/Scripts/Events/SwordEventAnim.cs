using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEventAnim : MonoBehaviour
{
    public GameObject sword;
    public float height = 0.1f;
    public int reward = 100;
    int clickCount = 0;
    Vector3 pos;

    void Update()
    {
        if (sword != null)
        {
            pos = sword.transform.position;

            if (Input.GetButtonDown("Action") && Vector3.Distance(pos, this.transform.position) < 5)
            {
                clickCount++;

                if (clickCount >= 9 && clickCount <= 22)
                {
                    sword.transform.Rotate(0, 0, -10);
                }
                else if (clickCount > 22 && clickCount <= 30)
                {
                    float newX = pos.x + height;
                    float newY = pos.y - height;
                    sword.transform.position = new Vector3(newX, newY, pos.z);
                }
                else if (clickCount > 30)
                {
                    // Barczyko jak będziesz robić animację miecza to na samym końcu musi być coś takiego żeby gracz dostał nagrodę
                    Destroy(sword);
                    PlayerInfo.collectedCandy += reward;
                }
                else
                {
                    float newY = pos.y + height;
                    sword.transform.position = new Vector3(pos.x, newY, pos.z);
                }
            }
        }
    }
}
