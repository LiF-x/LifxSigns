/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin</credits>
* <description>Text Signposts Introduced to LIF:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxBuildings))
{
    new ScriptObject(LiFxBuildings)
    {
    };
}
package LiFxBuildings
{
  function LiFxBuildings::setup() {
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxBuildings);

  }
  function LiFxBuildings::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/LiFxBuildings", "Buildingmaterials.cs");
  }
  function LiFxBuildings::path() {
    return $Con::File;
  }
};
activatePackage(LiFxBuildings);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxBuildings);