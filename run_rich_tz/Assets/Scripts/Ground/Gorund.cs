namespace Gorund
{
    using UnityEngine;

    /// <summary>
    /// class of ground
    /// </summary>
    public class Gorund : MonoBehaviour
    {
        public bool IsPasset => isPassed;

        [SerializeField] protected bool isPassed = true;
    }
}
