using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject human;
    public float value;
    public Vector3 sizeChange;
   
    public void MoveLeft()
    {
        value = value - 0.1f;
        human.transform.position = new Vector3(value, (float)0.8799996, (float)5.910473);
    }
    public void RotateLeft()
    {
        human.transform.Rotate(0f, 10f, 0f);
    }
    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + new Vector3(0f,0f,0.1f);
    }
    public void Reset()
    {
        human.transform.position = new Vector3((float)2.834061, (float)0.8999996, (float) 5.910473);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, (float)-9.817, 0));
        human.transform.localScale = new Vector3(1,1,1);
    }
}
