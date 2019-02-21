using UnityEngine;

namespace Assets
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        public Singleton()
        {
            if (Instance != null)
                Debug.Log("Singleton " + typeof(T) + " already exists -- overwriting");
            Instance = this as T;
        }
    }
}