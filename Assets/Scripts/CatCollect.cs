using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatCollect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Cursor.visible = true;

    }

}
