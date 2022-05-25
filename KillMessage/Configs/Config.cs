using System.ComponentModel;
using System.IO;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace KillMessage.Configs
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("数据库文件将存储在的文件夹")]
        public string DatabaseFolder { get; set; } = Path.Combine(Paths.Plugins, "KillMessage");

        [Description("是否向加入的玩家发送消息，告诉他们插件的情况")]
        public bool SendConsoleMessage { get; set; } = true;

        [Description("击杀消息的字符限制")]
        public int CharLimit { get; set; } = 32;

        [Description("黑名单上的单词列表")]
        public string[] BlacklistedWords { get; set; } = {"your", "blacklisted", "words", "go", "here"};

        [Description("显示给被杀玩家的消息大小")]
        public int MessageSize { get; set; } = 30;

        [Description("显示给被杀玩家的消息持续时间")] 
        public ushort MessageDuration { get; set; } = 3;

        [Description("是否应该用广播代替提示")]
        public bool UseBroadcast { get; set; } = false;
        
        [Description("可用颜色列表。确保使用SCPSL Wiki颜色")]
        public string[] AvailableColors { get; set; } = {
            "pink", "red", "brown", "silver", "light_green", "crimson", "cyan", "aqua", "deep_pink", "tomato", "yellow", "magenta", "blue_green",
            "orange"
        };

        [Description("如果玩家自杀，是否发送消息")]
        public bool ShowOnSuicide { get; set; } = true;
    }
}