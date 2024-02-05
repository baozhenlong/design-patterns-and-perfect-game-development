
// 战斗状态
public class BattleState : ISceneState
{
    public BattleState(SceneStateController controller) : base(controller)
    {
        StateName = "BattleState";
    }
    public override void StateBegin()
    {
        PBaseDefenseGame.Instance.Initialize();
    }

    public override void StateEnd()
    {
        PBaseDefenseGame.Instance.Release();
    }

    public override void StateUpdate()
    {
        // 游戏逻辑
        PBaseDefenseGame.Instance.Update();
        // 游戏是否结束
        if (PBaseDefenseGame.Instance.IsGameOver())
        {
            controller.SetState(new MainMenuState(controller), "MainMenuScene");
        }
    }
}