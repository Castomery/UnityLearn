using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Member_Hiding
{
    public class Orc : Enemy
    {
        new public void Yell()
        {
            Debug.Log("Orc version of the Yell() method");
        }
    }
}


