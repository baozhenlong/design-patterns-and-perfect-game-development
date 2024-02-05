

using System;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    // 场景状态
    readonly SceneStateController sceneStateController = new();

    private void Awake()
    {
        // 切换场景不会删除
        DontDestroyOnLoad(gameObject);
        // 随机数种子
        UnityEngine.Random.InitState((int)DateTime.Now.Ticks);
    }

    private void Start()
    {
        // 设置初始的场景
        sceneStateController.SetState(new StartState(sceneStateController), "");
    }

    private void Update()
    {
        sceneStateController.StateUpdate();
    }
}