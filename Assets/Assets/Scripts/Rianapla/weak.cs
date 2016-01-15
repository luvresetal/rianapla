using UnityEngine;
using System.Collections;

public class weak : MonoBehaviour {
    //よわよわプラ独自の動作
    //現状はつぶされたときの悲鳴音声だけ
    //分裂もしない

    //リアナプラの動き方
    public float speed = 0.1f;
    int time = 0;
    Vector2 moving;

    void Start()
    {
        ++MainLoop.number;
    }

    // Update is called once per frame
    void Update()
    {
        //移動はランダムで　ゆっくり目な感じで？;
        if (time >= 1)
        {
            --time;
        }
        else
        {
            Vector2 reset = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().velocity = reset;
            time = Random.Range(1, 10);
            moving.x = Random.Range(-5, 6);
            moving.y = Random.Range(-7, 8);
            GetComponent<Rigidbody2D>().velocity = moving * speed;
        }
    }

    void OnMouseDown()
    {
        Vector2 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);

        if (aCollider2d)
        {
            GameObject obj = aCollider2d.transform.gameObject;
            Destroy(obj);
            SoundManager.weakSound = true;
            --MainLoop.number;
        }
    }
}
