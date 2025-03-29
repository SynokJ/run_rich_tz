namespace Player.Movement
{
    using UnityEngine;
    using Gorund;

    /// <summary>
    /// class of movement snap
    /// </summary>
    public class PlayerSnapMovement : MonoBehaviour
    {
        [SerializeField] protected LayerMask groundLayer = default;
        [SerializeField, Min(0.0f)] protected float duration = 0.25f;

        protected Ray tempRay = default;
        protected RaycastHit hit = default;
        protected Vector3 targetTr = default;

        protected virtual void Update()
        {
            SurfaceAlignment();
            transform.forward = Vector3.Slerp(transform.forward, targetTr, Time.deltaTime * (1.0f / duration));
        }

        protected virtual void SurfaceAlignment()
        {
            tempRay = new Ray(transform.position, -transform.up);
            if (Physics.Raycast(tempRay, out hit, groundLayer))
            {
                targetTr = hit.transform.forward;
            }
        }
    }
}