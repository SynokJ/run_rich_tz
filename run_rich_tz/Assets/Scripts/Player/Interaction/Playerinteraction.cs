namespace Player.Interaction
{
    using Interactables;
    using UnityEngine;

    public class Playerinteraction : MonoBehaviour
    {
        protected AbstractInteractiable tempInteractable = default;

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out tempInteractable))
            {
                tempInteractable.OnInteracted();
            }
        }
    }
}