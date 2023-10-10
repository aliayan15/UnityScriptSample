#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace Managers
{

    [CustomEditor(typeof(GameManager))]
    public class GameManagerCustomEditor : Editor
    {
        /// <summary>
        /// Girilen game state'di kur.
        /// </summary>
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GameManager myScript = (GameManager)target;

            if (GUILayout.Button("Set Game State"))
            {
                myScript.SetState(myScript.GameStateToSet);
            }
        }
    }

}
#endif
