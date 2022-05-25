using System.ComponentModel;
using Exiled.API.Interfaces;

namespace KillMessage.Configs
{
    public class Translations : ITranslation
    {
        [Description("当玩家加入时发送给他们的控制台消息。%helpmsg 将替换为帮助消息")]
        public string ConsoleMessage { get; set; } = "\n<b>KillMessage</b>\n" +
                                                     "一个向你杀的玩家显示消息的插件\n$helpmsg";

        [Description(
            "显示给杀手玩家的消息。$message 将被替换为消息。$author 将被凶手取代")]
        public string Message { get; set; } = "$message - <b>$author</b>";
        [Description("帮助信息。 $current 将替换为当前消息")]
        public string HelpMessage { get; set; } = "\nUsage:\n" +
                                                  "· kmsg set - 设置你的击杀信息\n" +
                                                  "· kmsg delete - 删除你的击杀信息\n" +
                                                  "· kmsg toggle - 切换你是否能看到杀人信息\n" +
                                                  "· kmsg color - 切换你的击杀颜色\n" +
                                                  "· 您当前的信息和颜色: $current / $color";

        [Description("消息未设置翻译（显示在帮助消息中）")]
        public string MessageNotSet { get; set; } = "未设置";
        
        [Description("未经允许使用命令发送给玩家的消息")]
        public string NoPerms { get; set; } = "不允许.";

        [Description("删除命令响应")]
        public string DeleteCmd { get; set; } = "击杀消息删除。";

        [Description("最大字符错误。$limit 将替换为字符限制")]
        public string MaxChars { get; set; } = "您最多只能输入 $limit 个字符";

        [Description("空消息错误响应")]
        public string EmptyMessage { get; set; } =
            "你不能设置一个空的消息，如果你想删除你的消息，使用kmsg delete";

        [Description("设置命令响应")] 
        public string SetCmd { get; set; } = "击杀消息设置";

        [Description("当您试图用黑名单单词设置邮件时显示的消息")]
        public string BlacklistedWords { get; set; } = "你的信息中有黑名单上的单词";

        [Description("找不到颜色错误。 $color 将被替换为")]
        public string ColorNotFound { get; set; } = "找不到 $color ";

        [Description("颜色命令响应")]
        public string ColorCmd { get; set; } = "颜色更新";

        [Description("颜色空错误响应")]
        public string ColorEmpty { get; set; } =
            "您设置的颜色不能为空，如果要将颜色设置为白色，请使用默认或白色";

        [Description("消息隐藏响应")]
        public string MessagesHidden { get; set; } = "击杀信息以隐藏";
        [Description("消息不再隐藏响应")]
        public string MessagesNotHidden { get; set; } = "击杀信息以显示";

    }
}