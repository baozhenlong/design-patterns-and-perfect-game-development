// 场景状态
public class ISceneState
{
    // 状态名称，可以在调试时使用
    private string stateName = "ISceneState";
    public string StateName
    {
        get { return stateName; }
        set { stateName = value; }
    }

    // 控制者
    protected SceneStateController controller = null;

    // 建造者
    public ISceneState(SceneStateController controller)
    {
        this.controller = controller;
    }

    // 开始
    public virtual void StateBegin() { }

    // 结束
    public virtual void StateEnd() { }

    // 更新
    public virtual void StateUpdate() { }

    public override string ToString()
    {
        return string.Format("[ISceneState: StateName = {0}]", StateName);
    }
}