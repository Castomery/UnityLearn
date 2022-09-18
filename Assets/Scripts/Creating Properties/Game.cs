using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Creating_Properties
{
    public class Game : MonoBehaviour
    {
        void Start()
        {
            Player myPlayer = new Player();

            myPlayer.Experience = 5;
            int x = myPlayer.Experience;
        }
    }
}

