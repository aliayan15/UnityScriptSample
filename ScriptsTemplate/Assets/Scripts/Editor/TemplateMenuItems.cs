#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace TemplateHelpers
{

    public class TemplateMenuItems : MonoBehaviour
    {
        [MenuItem("My Section/Example", priority = 1)]
        private static void Example()
        {
            //var currentScene = EditorSceneManager.GetActiveScene();
            //EditorSceneManager.SaveScene(currentScene);
            //EditorConfigManager.SetTestScene(currentScene.name, currentScene.path);
            //EditorSceneManager.OpenScene(GlobalConsts.MainScenePath);
            //EditorApplication.EnterPlaymode();
        }

        
    }

}
#endif