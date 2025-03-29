namespace Gameplay
{
    using Player.Interaction;
    using UnityEditor;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class FinishController : MonoBehaviour
    {
        [SerializeField] protected SceneAsset sceneToLoad = default;

        protected Playerinteraction player = default;

        private void OnTriggerEnter(Collider other)
        {
            if(other.TryGetComponent(out player))
            {
                SceneManager.LoadScene(sceneToLoad.name);
            }
        }
    }
}
