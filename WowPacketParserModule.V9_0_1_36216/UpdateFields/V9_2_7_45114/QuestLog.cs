using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V9_0_1_36216.UpdateFields.V9_2_7_45114
{
    public class QuestLog : IQuestLog
    {
        public System.Nullable<int> QuestID { get; set; }
        public System.Nullable<uint> StateFlags { get; set; }
        public System.Nullable<uint> EndTime { get; set; }
        public System.Nullable<uint> AcceptTime { get; set; }
        public System.Nullable<uint> ObjectiveFlags { get; set; }
        public System.Nullable<short>[] ObjectiveProgress { get; } = new System.Nullable<short>[24];
    }
}

