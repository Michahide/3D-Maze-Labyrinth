using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image image;
    //Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Progress());
    }

    // Update is called once per frame
    IEnumerator Progress()
    {
        image.fillAmount = 0;
        yield return new WaitForSeconds(1);

        var asyncOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while (asyncOp.isDone == false)
        {
            image.fillAmount = asyncOp.progress;
            yield return null;
            Debug.Log(asyncOp.progress * 100);
        }
    }
}
