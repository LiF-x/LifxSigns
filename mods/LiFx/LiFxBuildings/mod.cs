/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Text Signposts introduced to Lif:YO</description>
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
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, Sign, LiFxBuildings);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, pvesign, LiFxBuildings);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, pvpsign, LiFxBuildings);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, rpSignpost, LiFxBuildings);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, CautionSignpost, LiFxBuildings);
        LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, EventSignpost, LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxEventSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxpveSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxpvpSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxrpSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LifxCautionSignpost(), LiFxBuildings);
        LiFx::registerObjectsTypes(LiFxBuildings::LiFxcategory(), LiFxBuildings);

    }
    function LiFxBuildings::version() {
        return "0.0.1";
    }

        function LiFxBuildings::LiFxcategory() {
        return new ScriptObject(LiFxcategory : ObjectsTypes)
        {
            id = 4095; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Buildings";
            ParentID = 12;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 0;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "LiFx Buildings Catagory";
            BasePrice = NULL;
            OwnerTimeout = NULL;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
    function LiFxBuildings::LifxSignpost() {
        return new ScriptObject(LifxSignpost : ObjectsTypes)
        {
            id = 2570; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "LiFx Sign";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/LiFxSignpost.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxBuildings::LifxpveSignpost() {
        return new ScriptObject(LifxpveSignpost : ObjectsTypes)
        {
            id = 2571; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "PVE Sign Post";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/PVERecipe.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxBuildings::LifxpvpSignpost() {
        return new ScriptObject(LifxpvpSignpost : ObjectsTypes)
        {
            id = 2572; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "PVP Sign Post";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/PVPRecipe.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxBuildings::LifxrpSignpost() {
        return new ScriptObject(LifxrpSignpost : ObjectsTypes)
        {
            id = 2573; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "RP Sign Post";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/RPRecipe.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxBuildings::LifxCautionSignpost() {
        return new ScriptObject(LifxCautionSignpost : ObjectsTypes)
        {
            id = 2574; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Caution Sign Post";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/CautionRecipe.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
        function LiFxBuildings::LifxEventSignpost() {
        return new ScriptObject(LifxEventSignpost : ObjectsTypes)
        {
            id = 2575; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Event Sign Post";
            ParentID = 4095;
            IsContainer = 0;
            IsMovableObject = 0;
            IsUnmovableobject = 1;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 0;
            Length = 0; 
            MaxStackSize = 0;
            UnitWeight = 5000;
            BackgrndImage = 0;
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/no_image.png";
            Description = "Object from LiFx Buildings \n Signpost for LIFX AND YO LAUNCHER FRAMEWORK";
            BasePrice = 0;
            OwnerTimeout = 0;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

  function LiFxBuildings::Sign() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "SignRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'LiFx Sign post', 'Object from Lifx Buildings',        32,               18,          60,        2570,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/LiFxSignpost.png') RETURNING ID");
  }
  function LiFxBuildings::SignRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

  function LiFxBuildings::pvesign() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "pvesignRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'PVE sign post', 'Object from Lifx Buildings',        32,               18,          60,        2571,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/PVERecipe.png') RETURNING ID");
  }
  function LiFxBuildings::pvesignRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }

    function LiFxBuildings::pvpsign() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "pvpsignRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'PVP sign post', 'Object from Lifx Buildings',        32,               18,          60,        2572,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/PVPRecipe.png') RETURNING ID");
  }
  function LiFxBuildings::pvpsignRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
    function LiFxBuildings::rpSignpost() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "rpsignRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'RP sign post', 'Object from Lifx Buildings',        32,               18,          60,        2573,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/RPRecipe.png') RETURNING ID");
  }
  function LiFxBuildings::rpsignRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
    function LiFxBuildings::CautionSignpost() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "CautionSignpostRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Caution Signpost', 'Object from Lifx Buildings',        32,               18,          60,        2574,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/CautionRecipe.png') RETURNING ID");
  }
  function LiFxBuildings::CautionSignpostRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
  function LiFxBuildings::EventSignpost() {
                                   //dbi.update("INSERT IGNORE INTO `recipe` VALUES (NULL,      Name,                 Description,      StartingToolsID,   SkillTypeID, SkillLvl, ResultObjectTypeID, SkillDepends,       Quantity, Autorepeat, isBluePrint, ImagePath)
    dbi.Select(LiFxBuildings, "EventSignpostRequirements","INSERT IGNORE INTO `recipe` VALUES (NULL, 'Event Sign Post', 'Object from Lifx Buildings',        32,               18,          60,        2575,               25,           1,        0,          0,           'yolauncher/modpack/mods/LiFx/LiFxBuildings/art/2D/recipes/no_image.png') RETURNING ID");
  }
  function LiFxBuildings::EventSignpostRequirements(%this, %resultSet) {
    if(%resultSet.ok() && %resultSet.nextRecord()) {
      %lastInsert = %resultSet.getFieldValue("ID");
    //dbi.update("INSERT IGNORE INTO `recipe_requirement` VALUES (RecipeID,            MaterialObjectTypeID, Quality, Influence, Quantity, IsRegionalItemRequired)
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  1130,                  0,       40,         200,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  281,                  0,       15,         150,       0)");
      dbi.Update("INSERT IGNORE INTO `recipe_requirement` VALUES (NULL, " @ %lastInsert @ ",  233,                  0,       15,         1,       0)");
    }
    dbi.remove(%resultSet);
    %resultSet.delete();
  }
};
activatePackage(LiFxBuildings);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxBuildings);