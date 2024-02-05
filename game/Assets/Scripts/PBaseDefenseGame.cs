using UnityEngine;

public class PBaseDefenseGame
{

    // 单例模式
    private static PBaseDefenseGame _instance;
    public static PBaseDefenseGame Instance
    {
        get
        {
            _instance ??= new PBaseDefenseGame();
            return _instance;
        }
    }
    private PBaseDefenseGame() { }

    #region 游戏系统
    // 游戏事件系统
    private GameEventSystem gameEventSystem = null;
    // 兵营系统
    private CampSystem campSystem = null;
    // 关卡系统
    private StageSystem stageSystem = null;
    // 角色管理系统
    private CharacterSystem characterSystem = null;
    // 行动力系统
    private APSystem aPSystem = null;
    // 成就系统
    private AchievementSystem achievementSystem = null;
    #endregion

    #region 界面
    // 兵营界面
    private CampInfoUI campInfoUI = null;
    // 战士信息界面
    private SoldierInfoUI soldierInfoUI = null;
    // 游戏状态界面
    private GameStateInoUI gameStateInoUI = null;
    // 游戏暂停界面
    private GamePauseUI gamePauseUI = null;
    #endregion

    // 场景控制状态
    private bool gameOver = false;

    // 初始化游戏相关设置
    public void Initialize()
    {
        gameOver = false;

        gameEventSystem = new GameEventSystem(this);
        campSystem = new CampSystem(this);
        stageSystem = new StageSystem(this);
        characterSystem = new CharacterSystem(this);
        aPSystem = new APSystem(this);
        achievementSystem = new AchievementSystem(this);

        campInfoUI = new CampInfoUI(this);
        soldierInfoUI = new SoldierInfoUI(this);
        gameStateInoUI = new GameStateInoUI(this);
        gamePauseUI = new GamePauseUI(this);

        // 注入其他系统
        EnemyAI.SetStageSystem(stageSystem);
    }

    // 释放游戏系统
    public void Release()
    {

    }

    public void Update()
    {
        // 玩家输入
        InputProcess();

        // 游戏系统更新
        gameEventSystem.Update();
        campSystem.Update();
        stageSystem.Update();
        characterSystem.Update();
        aPSystem.Update();
        achievementSystem.Update();

        // 界面更新
        campInfoUI.Update();
        soldierInfoUI.Update();
        gameStateInoUI.Update();
        gamePauseUI.Update();
    }

    private void InputProcess()
    {
        // 鼠标左键
        if (Input.GetMouseButtonUp(0) == false)
        {
            return;
        }

        // 由摄像机产生一条射线
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);
        // 遍历每一个被 hit 到的 gameObject
        foreach (RaycastHit hit in hits)
        {
            // 是否有兵营被鼠标单击
            CampOnClick campOnClick = hit.transform.gameObject.GetComponent<CampOnClick>();
            if (campOnClick != null)
            {
                campOnClick.OnClick();
                return;
            }
            // 是否有角色被鼠标单击
            SoldierOnClick soldierOnClick = hit.transform.gameObject.GetComponent<SoldierOnClick>();
            if (soldierOnClick != null)
            {
                soldierOnClick.OnClick();
                return;
            }
        }
    }

    // 游戏状态
    public bool IsGameOver()
    {
        return gameOver;
    }

    // 当前敌人数量
    public int GetEnemyCount()
    {
        if (characterSystem == null)
        {
            return 0;
        }
        return characterSystem.GetEnemyCount();
    }

    #region 游戏系统之间的相互沟通
    // 升级 Soldier
    public void UpdateSolider()
    {
        characterSystem?.UpdateSolider();
    }
    // 增加 Solider
    public void AddSolider(ISoldier solider)
    {
        characterSystem?.AddSolider(solider);
    }
    // 删除 Soldier
    public void RemoveSolider(ISoldier solider)
    {
        characterSystem?.RemoveSolider(solider);
    }
    // 增加 Enemy
    public void AddEnemy(IEnemy enemy)
    {
        characterSystem?.AddEnemy(enemy);
    }
    // 删除 Enemy
    public void RemoveEnemy(IEnemy enemy)
    {
        characterSystem?.RemoveEnemy(enemy);
    }

    // 显示兵营信息
    public void ShowCampInfo(ICamp camp)
    {
        campInfoUI.ShowInfo(camp);
        soldierInfoUI.Hide();
    }

    // 显示 Solider 信息
    public void ShowSoliderInfo(ISoldier soldier)
    {
        soldierInfoUI.ShowInfo(soldier);
        campInfoUI.Hide();
    }

    // 注册游戏事件
    public void RegisterGameEvent(EnumGameEvent enumGameEvent, IGameEventObserver gameEventObserver)
    {
        gameEventSystem.RegisterGameEvent(enumGameEvent, gameEventObserver);
    }
    // 通知游戏事件
    public void NotifyGameEvent(EnumGameEvent enumGameEvent, object param)
    {
        gameEventSystem.NotifyGameEvent(enumGameEvent, param);
    }
    #endregion

    #region 成就记录
    // 存盘
    private void SaveData()
    {
        AchievementSaveData achievementSaveData = achievementSystem.CreateSaveData();
        achievementSaveData.SaveData();
    }
    // 读取存盘记录
    private AchievementSaveData LoadData()
    {
        AchievementSaveData achievementSaveData = new();
        achievementSaveData.LoadData();
        achievementSystem.SetSaveData(achievementSaveData);
        return achievementSaveData;
    }
    #endregion

    // 执行角色系统的 Visitor
    public void RunCharacterVisitor(ICharacterVisitor characterVisitor)
    {
        characterSystem.RunVisitor(characterVisitor);
    }
}