using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace MyUtilities
{

    public static class HelperFunctions
    {

        #region Extension to easily create WaitForSeconds coroutines / Delay
        /// <summary>
        /// Create WaitForSeconds coroutine and Call action with delay.
        /// </summary>
        /// <param name="mono">GameObject That coroutine have</param>
        /// <param name="delay"></param>
        /// <param name="action"></param>
        /// <param name="isRealTime">WaitForSecondsRealtime or WaitForSeconds</param>
        /// <returns></returns>
        public static Coroutine Wait(this MonoBehaviour mono, float delay, UnityAction action, bool isRealTime = false)
        {
            if (isRealTime)
                return mono.StartCoroutine(ExecuteActionInRealtime(delay, action));
            else
                return mono.StartCoroutine(ExecuteActionInScaledTime(delay, action));
        }

        private static IEnumerator ExecuteActionInRealtime(float delay, UnityAction action)
        {
            yield return new WaitForSecondsRealtime(delay);
            action?.Invoke();
            yield break;
        }
        private static IEnumerator ExecuteActionInScaledTime(float delay, UnityAction action)
        {
            yield return new WaitForSeconds(delay);
            action?.Invoke();
            yield break;
        }
        #endregion

    }
}
