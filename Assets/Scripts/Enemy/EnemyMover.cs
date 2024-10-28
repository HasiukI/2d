using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyMover : ObjectMover
    {
        private void FixedUpdate()
        {
            Move();
        }

    }

}
