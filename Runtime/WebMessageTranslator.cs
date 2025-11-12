/// <summary>
/// Game Framework
/// 
/// 创建者：Hurley
/// 创建时间：2025-11-10
/// 功能描述：
/// </summary>

using GameEngine;

namespace Game.Module.Protocol.Protobuf
{
    /// <summary>
    /// Web服务类型通道的消息解析器对象类，用于对Web服务通道的网络消息数据进行加工
    /// </summary>
    public abstract class WebMessageTranslator : IMessageTranslator
    {
        /// <summary>
        /// 将指定的消息内容编码为可发送的消息字节流
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <returns>若编码有效的数据则返回其对应的字节流，否则返回null</returns>
        public byte[] Encode(object message)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// 将指定的消息字节流解码成消息内容
        /// </summary>
        /// <param name="buffer">消息字节流</param>
        /// <returns>返回解码后的消息内容，若解码失败则返回null</returns>
        public object Decode(byte[] buffer)
        {
            throw new System.NotImplementedException();
        }
    }
}
