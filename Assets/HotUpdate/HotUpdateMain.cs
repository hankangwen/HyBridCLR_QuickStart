using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HotUpdate
{
    public class HotUpdateMain : MonoBehaviour
    {
        private void Awake()
        {
            Entry.Start();
            GameObject.Destroy(this.gameObject);
        }
    }
}