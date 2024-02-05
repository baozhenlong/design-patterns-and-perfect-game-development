using UnityEngine;
using UnityEngine.SceneManagement;

// 场景状态控制者
public class SceneStateController
{
    private ISceneState state;
    private bool isRunBegin = false;

    private bool isLoadedScene = true;

    // 设置状态
    public void SetState(ISceneState state, string loadSceneName)
    {
        isRunBegin = false;
        // 载入场景
        LoadScene(loadSceneName);
        // 通知前一个 State 结束
        this.state?.StateEnd();
        // 设置
        this.state = state;
    }

    // 载入场景
    private void LoadScene(string loadSceneName)
    {
        if (string.IsNullOrEmpty(loadSceneName))
        {
            return;
        }
        isLoadedScene = false;
        AsyncOperation operation = SceneManager.LoadSceneAsync(loadSceneName);
        if (operation.isDone)
        {
            isLoadedScene = true;
        }
    }

    // 更新
    public void StateUpdate()
    {
        // 是否还在加载
        if (!isLoadedScene)
        {
            return;
        }

        if (state != null)
        {
            // 通知新的 state 开始
            if (!isRunBegin)
            {
                state.StateBegin();
                isRunBegin = true;
            }
            state.StateUpdate();
        }
    }
}