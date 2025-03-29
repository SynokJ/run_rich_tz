namespace Player.Movement
{
    using UnityEngine;
    using Gorund;

    /// <summary>
    /// class of player movement
    /// </summary>
    public class PlayerMovement : MonoBehaviour
    {
        public bool IsSideMoveAccepted => isSideMoveAccepted;

        [SerializeField, Min(0.0f)] protected float movementSpeed = 1.0f;
        [SerializeField] protected Rigidbody playerRb = default;
        [SerializeField] protected Transform playerTr = default;

        protected Vector3 moveDirectionForward = default;
        protected Vector3 moveDirectionSide = default;
        protected Vector3 currentPositionToMove = default;
        protected float sidePos = 0.0f;
        protected float currentSidePos = 0.0f;
        protected bool isSideMoveAccepted = true;

        private void OnTriggerStay(Collider other)
        {
            if (other.TryGetComponent(out Gorund gorund))
            {
                isSideMoveAccepted = false;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out Gorund gorund))
            {
                isSideMoveAccepted = true;
            }
        }

        protected virtual void Update()
        {
            moveDirectionForward = playerTr.forward * movementSpeed * Time.deltaTime;
            moveDirectionSide = playerTr.right * sidePos * Time.deltaTime;
            playerRb.MovePosition(playerRb.position + moveDirectionForward + moveDirectionSide);
        }

        /// <summary>
        /// method to change side pos
        /// </summary>
        /// <param name="sidePos"></param>
        public virtual void ChangeSidePos(float sidePos)
            => this.sidePos = sidePos;
    }
}