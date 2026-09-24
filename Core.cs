using Alta.Carpentry;
using Alta.Inventory;
using CustomRecipesAPI;
using MelonLoader;
using MelonLoader.Utils;
using UnityEngine;

[assembly: MelonInfo(typeof(StirringSpoonRecipe.Core), "StirringSpoonRecipe", "1.0.0", "CGNik", null)]
[assembly: MelonGame("Alta", "A Township Tale")]

namespace StirringSpoonRecipe
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Initialized.");
            CustomRecipesAPI.Core.SetUpRecipes += SetUpRecipes;
        }

        private void SetUpRecipes()
        {
            AssetBundle assetBundle = AssetBundle.LoadFromFile(Path.Combine(MelonEnvironment.ModsDirectory, "StirringSpoonRecipe/AssetBundles/!stirringspoonrecipe"));
            ChiselDefinition chiselDefinition_StirringSpoon = assetBundle.LoadAsset<ChiselDefinition>("Stirring Spoon Recipe.asset");

            Item stirringSpoon = Item.All.Where(item => item.Hash == 41010u).First();
            CustomRecipesAPI.Core.SetUpChiselDefinition(chiselDefinition_StirringSpoon, stirringSpoon.Glyph);
        }
    }
}