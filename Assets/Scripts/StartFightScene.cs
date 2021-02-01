using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFightScene : MonoBehaviour
{
    IEnumerator OnMouseDown()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene (sceneName: "Fight Scene");
    }
}
