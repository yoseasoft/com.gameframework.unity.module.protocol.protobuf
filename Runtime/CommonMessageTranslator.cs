/// <summary>
/// Game Framework
/// 
/// 创建者：Hurley
/// 创建时间：2025-11-10
/// 功能描述：
/// </summary>

namespace Game.Module.Protocol.Protobuf
{
    /// <summary>
    /// TCP类型通道的消息解析器对象类，用于对TCP通道的网络消息数据进行加工
    /// </summary>
    public class TcpMessageTranslator : SocketMessageTranslator
    { }

    /// <summary>
    /// WebSocket类型通道的消息解析器对象类，用于对WebSocket通道的网络消息数据进行加工
    /// </summary>
    public class WebSocketMessageTranslator : SocketMessageTranslator
    { }

    /// <summary>
    /// Http类型通道的消息解析器对象类，用于对Http通道的网络消息数据进行加工
    /// </summary>
    public class HttpMessageParser : WebMessageTranslator
    { }
}
