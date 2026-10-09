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
            Item stirringSpoon = Item.All.Where(item => item.Hash == 41010u).First();
            CustomRecipesAPI.Core.SetUpChiselDefinitionThroughCode(
                "Stirring Spoon Recipe",
                12521,
                stirringSpoon.Glyph,
                ChiselBlockSize.Medium,
                [11,10,0,1,5,3,7,2,9,4,6,8],
                [
                    CustomRecipesAPI.Core.CreatePrefabSpawnPosition(23950u, Vector3.zero, Quaternion.identity)
                ]
            );
        }
    }
}