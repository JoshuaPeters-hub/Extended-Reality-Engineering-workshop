using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    public Animator ObjectAnim;
    // Start is called before the first frame update

    public void expand()
    {
        ObjectAnim.SetBool("Type", false);
    }
    public void Detract()
    {
        ObjectAnim.SetBool("Type", true);
    }
}
