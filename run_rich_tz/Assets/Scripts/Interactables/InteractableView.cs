namespace Interactables
{
    using UnityEngine;

    [RequireComponent(typeof(Collider), typeof(Renderer))]
    public class InteractableView : MonoBehaviour
    {
        protected Collider colldier = default;
        protected Renderer rendere = default;

        protected virtual void Awake()
        {
            colldier = GetComponent<Collider>();
            rendere = GetComponent<Renderer>();
        }

        public virtual void HideInteractiable()
            => SetInteractableStatus(false);

        public virtual void ShoInteractiable()
            => SetInteractableStatus(true);

        protected virtual void SetInteractableStatus(bool status)
        {
            colldier.enabled = status;
            rendere.enabled = status;
        }
    }
}
