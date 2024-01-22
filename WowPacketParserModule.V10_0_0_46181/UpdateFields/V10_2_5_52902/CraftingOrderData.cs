using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_2_5_52902
{
    public class CraftingOrderData : ICraftingOrderData
    {
        public System.Nullable<int> Field_0 { get; set; }
        public System.Nullable<ulong> OrderID { get; set; }
        public System.Nullable<int> SkillLineAbilityID { get; set; }
        public System.Nullable<byte> OrderState { get; set; }
        public System.Nullable<byte> OrderType { get; set; }
        public System.Nullable<byte> MinQuality { get; set; }
        public System.Nullable<long> ExpirationTime { get; set; }
        public System.Nullable<long> ClaimEndTime { get; set; }
        public System.Nullable<long> TipAmount { get; set; }
        public System.Nullable<long> ConsortiumCut { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public WowGuid CustomerGUID { get; set; }
        public WowGuid CustomerAccountGUID { get; set; }
        public WowGuid CrafterGUID { get; set; }
        public WowGuid PersonalCrafterGUID { get; set; }
        public ICraftingOrderItem OutputItem { get; set; }
        public DynamicUpdateField<ICraftingOrderItem> Reagents { get; } = new DynamicUpdateField<ICraftingOrderItem>();
        public string CustomerNotes { get; set; }
    }
}

