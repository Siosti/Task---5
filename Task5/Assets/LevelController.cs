using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void LoadLevel(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }
}
