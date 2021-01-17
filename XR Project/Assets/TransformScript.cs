using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScript : MonoBehaviour
{
    public List<GameObject> Parts = new List<GameObject>();
    public bool Separate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Separate)
        {
            FixedPositionRight(Parts[0].transform, 5f);
            FixedPositionRight(Parts[1].transform, 2.71f);
            FixedPositionRight(Parts[2].transform, 0.49f);
            FixedPositionLeft(Parts[3].transform, -4);
            FixedPositionLeft(Parts[4].transform, -5);
            FixedPositionLeft(Parts[5].transform, -6);
            FixedPositionLeft(Parts[6].transform, -8);
        }
    }

    void FixedPositionRight(Transform Value, float Pos)
    {
        Value.Translate(5 * Time.deltaTime, 0, 0);
        if(Value.position.x >= Pos)
        {
            Value.position = new Vector3(Pos, Value.position.y, Value.position.z);
        }
    }
    void FixedPositionLeft(Transform Value,float Pos)
    {
        Value.Translate(-5 * Time.deltaTime, 0, 0);
        if (Value.position.x <= Pos)
        {
            Value.position = new Vector3(Pos, Value.position.y, Value.position.z);
        }
    }
}
