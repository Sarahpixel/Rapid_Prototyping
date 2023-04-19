using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayTime : GameBehaviour
{
    public enum Direction { Up, Down, Right, Left}
    public Ease moveEase;
    public Ease scaleEase;
    public GameObject player;
    public float tweenTime = 2;
    public float moveDistance = 5;
    // Start is called before the first frame update
    void Start()
    {
        /*ExecuteAfterSeconds(2, () => ScaleToZero(player)); //Advance programing lambda expression

        ExecuteAfterSeconds(2, () =>
        {
            ChangePlayerColor();
            print("Yay");
        });*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          /*  ChangePlayerColor()*/;
        }
        if (Input.GetKeyDown(KeyCode.D))
            MovePlayer(Direction.Right);

        if (Input.GetKeyDown(KeyCode.S))
            MovePlayer(Direction.Down);
        
        if (Input.GetKeyDown(KeyCode.A))
            MovePlayer(Direction.Left);
        
        if (Input.GetKeyDown(KeyCode.W))
            MovePlayer(Direction.Up);
        
        if (Input.GetKeyDown(KeyCode.R))
            ScalePlayer(Vector3.one);
    }
    void ScalePlayer(Vector3 _scaleTo)
    {
        player.transform.DOScale(Vector3.one * 1.2f, tweenTime).SetEase(scaleEase);
    }
    void MovePlayer(Direction _direction)
    {
        switch (_direction)
        {
            case Direction.Right:
                player.transform.DOMoveX(player.transform.position.x + moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
            case Direction.Left:
                player.transform.DOMoveX(player.transform.position.x - moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
            case Direction.Up:
                player.transform.DOMoveZ(player.transform.position.z + moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;
            case Direction.Down:
                player.transform.DOMoveZ(player.transform.position.z - moveDistance, tweenTime).SetEase(moveEase).OnComplete(() => ShakeCamera());
                break;

        }
        ScalePlayer(player.transform.localScale * 1.2f);
        
        void ShakeCamera()
        {
            //Camera.main.DOShakePosition(tweenTime / 2, 0.4f);
            //_UI.TweenScore();
            
        }

        //void ChangePlayerColor()
        //{
        //    //player.GetComponent<Renderer>().material.color = GetRandomColor();

        //    player.GetComponent<Renderer>().material.DOColor(GetRandomColor(), 0.5f);
        //}

    }

}