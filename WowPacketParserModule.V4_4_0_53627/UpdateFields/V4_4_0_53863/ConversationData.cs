using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V4_4_0_53627.UpdateFields.V4_4_0_53863
{
    public class ConversationData : IMutableConversationData
    {
        public System.Nullable<int> LastLineEndTime { get; set; }
        public IConversationLine[] Lines { get; set; }
        public DynamicUpdateField<IConversationActor> Actors { get; } = new DynamicUpdateField<IConversationActor>();
    }
}

