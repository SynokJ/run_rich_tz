namespace Interactables
{
    using UnityEngine;

    public abstract class AbstractInteractiable : MonoBehaviour
    {
        [SerializeField] protected InteractableView interactableView = default;

        /// <summary>
        /// method to interact
        /// </summary>
        public virtual void OnInteracted()
            => interactableView.HideInteractiable();
    }
}