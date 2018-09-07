using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class destroyOnClick : MonoBehaviour
{

    public int scoreValue;

    private GameController gameController;




    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
            gameController = gameControllerObject.GetComponent<GameController>();
        if (gameController == null)
            Debug.Log("no gamecontroller script");
    }

    private void Update()
    {
        DestroyTouch();
    }

#if UNITY_EDITOR
    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameController.AddScore(scoreValue);
    }
#endif




#if UNITY_ANDROID

    private void DestroyTouch()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint((Input.GetTouch(0).position)), Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
                gameController.AddScore(scoreValue);
            }
        }
    }

#endif



}
