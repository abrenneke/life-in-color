﻿using UnityEngine;
using UnityEngine.Events;

namespace Game
{
    public class Interactable : MonoBehaviour
    {
        public UnityEvent OnInteract;

        public Collider2D Collider { get; private set; }

        private void Awake()
        {
            Collider = GetComponentInChildren<Collider2D>();
        }

        public void Interact()
        {
            OnInteract.Invoke();
        }
    }
}