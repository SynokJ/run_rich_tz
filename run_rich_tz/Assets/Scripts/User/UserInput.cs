namespace User.Input
{
    using Player.Movement;
    using UnityEngine;

    /// <summary>
    /// class of user Input 
    /// </summary>
    public class UserInput : MonoBehaviour
    {
        [SerializeField] protected PlayerMovement playerMovement = default;

        protected Touch firstTouch = default;
        protected float screenHorizontalCenter = 0.0f;
        protected float tempTouchPos = 0.0f;

        protected virtual void Awake()
            => screenHorizontalCenter = Screen.width * 0.5f;

        protected virtual void Update()
        {
            if (Input.touchCount > 0)
            {
                firstTouch = Input.GetTouch(0);
                if (firstTouch.phase == TouchPhase.Moved)
                {
                    tempTouchPos = firstTouch.position.x - screenHorizontalCenter;
                    if (playerMovement.IsSideMoveAccepted)
                    {
                        playerMovement.ChangeSidePos(tempTouchPos / screenHorizontalCenter);
                    }
                }
            }
        }
    }
}