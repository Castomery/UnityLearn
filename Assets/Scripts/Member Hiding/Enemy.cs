using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Member_Hiding
{
    public class Enemy : Humanoid
    {
        new public void Yell()
        {
            Debug.Log("Enemy version of the Yell() method");
        }
    }
}

