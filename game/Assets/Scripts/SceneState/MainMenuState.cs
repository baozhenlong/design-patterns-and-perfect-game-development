// 主菜单状态
using UnityEngine.UI;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateController controller) : base(controller)
    {
        StateName = "MainMenuState";
    }

    public override void StateBegin()
    {
        Button button = UITool.GetUIComponent<Button>("StartGameButton");
        if (button != null)
        {
            button.onClick.AddListener(() => OnStartGameButtonClick());
        }
    }

    // 开始战斗
    private void OnStartGameButtonClick()
    {
        controller.SetState(new BattleState(controller), "BattleScene");
    }
}