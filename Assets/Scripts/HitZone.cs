using System.Collections.Generic;
using UnityEngine;

public class HitZone : MonoBehaviour
{
    public float perfectPush;
    public float greatPush;
    public float goodPush;
    public float missPush;

    public CarController player;
    private List<GameObject> tireList = new List<GameObject>();

    //
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tireList.Count > 0)
            {
                GameObject tire = tireList[0]; // grab first overlapping
                float xdistance = Mathf.Abs(tire.transform.position.x - transform.position.x);
                if (xdistance < 0.1f)
                {
                    Debug.Log("Perfect!");
                    player.Push(perfectPush);
                }
                else if (xdistance < 0.3f)
                {
                    Debug.Log("Great!");
                    player.Push(greatPush);
                }
                else if (xdistance < 0.5f)
                {
                    Debug.Log("Good!");
                    player.Push(goodPush);
                }
                else
                {
                    Debug.Log("Miss...");
                    player.Push(missPush);
                    return;
                }

                tireList?.RemoveAt(0);
                Destroy(tire);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tire"))
        {
            tireList.Remove(collision.gameObject);
            // tire will be disposed later.
        }
    }

    /// <summary>
    /// Fires every physics frame (default: 50 times per second) as long as the collider is still overlapping the trigger.
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Tire") && !tireList.Contains(collision.gameObject))
        {
            tireList.Add(collision.gameObject);
        }
    }
}
