using BepInEx;
using ItemManager;

namespace IronFangAxe
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class IronFangAxe : BaseUnityPlugin
    {
        private const string ModName = "IronFangAxe";
        private const string ModVersion = "0.0.9";
        private const string ModGUID = "org.bepinex.plugins.ironfangaxe";

        public void Awake()
        {
            Item IronFangAxe = new Item("ironfang", "IronFangAxe", "Axe");
            IronFangAxe.Crafting.Add(CraftingTable.Forge, 3);
            IronFangAxe.RequiredItems.Add("Iron", 10);
            IronFangAxe.RequiredItems.Add("BlackMetal", 10);
            IronFangAxe.RequiredItems.Add("WolfFang", 4);
            IronFangAxe.RequiredItems.Add("Wood", 4);
            IronFangAxe.RequiredUpgradeItems.Add("Iron", 5);
            IronFangAxe.RequiredUpgradeItems.Add("BlackMetal", 5);
            IronFangAxe.RequiredUpgradeItems.Add("WolfFang", 2);
            IronFangAxe.CraftAmount = 1;

            Item IronFangHatchet = new Item("ironfanghatchet", "IronFangHatchet", "Axe");
            IronFangHatchet.Crafting.Add(CraftingTable.Forge, 3);
            IronFangHatchet.RequiredItems.Add("Iron", 12);
            IronFangHatchet.RequiredItems.Add("BlackMetal", 8);
            IronFangHatchet.RequiredItems.Add("WolfFang", 4);
            IronFangHatchet.RequiredItems.Add("Wood", 2);
            IronFangHatchet.RequiredUpgradeItems.Add("Iron", 6);
            IronFangHatchet.RequiredUpgradeItems.Add("BlackMetal", 3);
            IronFangHatchet.RequiredUpgradeItems.Add("WolfFang", 2);
            IronFangHatchet.CraftAmount = 1;

            Item IronFangBattleAxe = new Item("ironfangbattle", "IronFangBattleAxe", "Axe");
            IronFangBattleAxe.Crafting.Add(CraftingTable.Forge, 3);
            IronFangBattleAxe.RequiredItems.Add("Iron", 15);
            IronFangBattleAxe.RequiredItems.Add("BlackMetal", 12);
            IronFangBattleAxe.RequiredItems.Add("WolfFang", 10);
            IronFangBattleAxe.RequiredItems.Add("Wood", 8);
            IronFangBattleAxe.RequiredUpgradeItems.Add("Iron", 10);
            IronFangBattleAxe.RequiredUpgradeItems.Add("BlackMetal", 6);
            IronFangBattleAxe.RequiredUpgradeItems.Add("WolfFang", 6);
            IronFangBattleAxe.CraftAmount = 1;

        }
    }
}