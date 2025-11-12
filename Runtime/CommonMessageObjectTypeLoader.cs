/// <summary>
/// Game Framework
/// 
/// 创建者：Hurley
/// 创建时间：2025-11-10
/// 功能描述：
/// </summary>

using System.Reflection;
using GameEngine;

using SystemType = System.Type;

namespace Game.Module.Protocol.Protobuf
{
    /// <summary>
    /// 消息对象类型加载器通用对象类
    /// </summary>
    public class CommonMessageObjectTypeLoader : IMessageObjectTypeLoader
    {
        public IMessageObjectTypeLoader.MessageObjectTypeInfo Parse(SystemType messageType)
        {
            IMessageObjectTypeLoader.MessageObjectTypeInfo typeInfo = new IMessageObjectTypeLoader.MessageObjectTypeInfo();

            ProtoBuf.Extension.MessageAttribute messageAttr = messageType.GetCustomAttribute<ProtoBuf.Extension.MessageAttribute>();
            if (null != messageAttr)
                typeInfo.opcode = messageAttr.Opcode;

            ProtoBuf.Extension.MessageResponseTypeAttribute messageResponseTypeAttr = messageType.GetCustomAttribute<ProtoBuf.Extension.MessageResponseTypeAttribute>();
            if (null != messageResponseTypeAttr)
                typeInfo.responseCode = messageResponseTypeAttr.Opcode;

            return typeInfo;
        }
    }
}
