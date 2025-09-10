using Unity.Mathematics;
using UnityEngine;

public class NeedleController : MonoBehaviour
{
    public float incAngle;
    public Transform objTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objTransform.rotation = Quaternion.Euler(0, 0, 90f);
    }

    public void MoveTheNeedle(bool clockwise)
    {
        float angleToMoveTo = clockwise ? objTransform.eulerAngles.z - incAngle : objTransform.eulerAngles.z + incAngle;
        objTransform.rotation = Quaternion.Euler(0, 0, angleToMoveTo);
    }
}
