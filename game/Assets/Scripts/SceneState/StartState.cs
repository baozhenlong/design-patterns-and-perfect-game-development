// 开始状态
public class StartState : ISceneState
{
    public StartState(SceneStateController controller) : base(controller)
    {
        StateName = "StartState";
    }

    // 开始
    public override void StateBegin() { }

    // 更新
    public override void StateUpdate()
    {
        controller.SetState(new MainMenuState(controller), "MainMenuScene");
    }
}