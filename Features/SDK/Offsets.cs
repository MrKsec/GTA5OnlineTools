﻿namespace GTA5OnlineTools.Features.SDK;

public class Offsets
{
    public class Mask
    {
        public const string WorldMask = "48 8B 05 ?? ?? ?? ?? 45 ?? ?? ?? ?? 48 8B 48 08 48 85 C9 74 07";
        public const string BlipMask = "4C 8D 05 ?? ?? ?? ?? 0F B7 C1";
        public const string GlobalMask = "4C 8D 05 ?? ?? ?? ?? 4D 8B 08 4D 85 C9 74 11";

        public const string ReplayInterfaceMask = "48 8D 0D ?? ?? ?? ?? 48 8B D7 E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 8A D8 E8";
        public const string NetworkPlayerManagerMask = "48 8B 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B C8 E8 ?? ?? ?? ?? 48 8B CF";

        public const string ViewPortMask = "48 8B 15 ?? ?? ?? ?? 48 8D 2D ?? ?? ?? ?? 48 8B CD";
        public const string CCameraMask = "48 8B 05 ?? ?? ?? ?? 4A 8B 1C F0";
        public const string AimingPedMask = "48 8B 0D ?? ?? ?? ?? 48 85 C9 74 0C 48 8D 15 ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 89 1D";

        public const string WeatherMask = "48 83 EC ?? 8B 05 ?? ?? ?? ?? 8B 3D ?? ?? ?? ?? 49";

        public const string FriendListMask = "48 8B 0D ?? ?? ?? ?? 8B C6 48 8D 5C 24 70";
        public const string PickupDataMask = "48 8B 05 ?? ?? ?? ?? 48 8B 1C F8 8B";
        public const string UnkModelMask = "4C 8B 15 ?? ?? ?? ?? 49 8B 04 D2 44 39 40 08";

        public const string PlayerchatterNameMask = "48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 0D ?? ?? ?? ?? 83";
    }

    ////////////////////////////////////////////////////////////////////

    public const int InitSession = 1574587;
    public const int SessionType = 1575004;

    public const int PlayerNameDisPlay_Epic = 0x2C34944;
    public const int PlayerNameDisPlay_Steam = 0x2C395D4;

    //public const int BunkerValue_Epic = 0x26471A0;
    //public const int BunkerValue_Steam = 0x264C780;

    ////////////////////////////////////////////////////////////////////

    // Vehicle Menus Globals
    public const int oVMCreate = 2463533;      // Create any vehicle.
    public const int oVMYCar = 2810287;        // Get my car.
    public const int oVGETIn = 2409299;        // Spawn into vehicle.
    public const int oVMSlots = 1323703;       // Get vehicle slots.

    // Some Player / Network times associated Globals
    public const int oPlayerGA = 2441237;
    public const int oPlayerIDHelp = 2689156;
    public const int oNETTimeHelp = 2703656;

    ////////////////////////////////////////////////////////////////////

    public class Player
    {
        public static int[] Health = new int[] { 0x08, 0x280 };
        public static int[] MaxHealth = new int[] { 0x08, 0x2A0 };
        public static int[] Armor = new int[] { 0x08, 0x1530 };

        public static int[] RunSpeed = new int[] { 0x08, 0x10C8, 0xCF0 };
        public static int[] SwimSpeed = new int[] { 0x08, 0x10C8, 0x170 };
        public static int[] StealthSpeed = new int[] { 0x08, 0x10C8, 0x18C };

        public static int[] GodMode = new int[] { 0x08, 0x189 };
        public static int[] Wanted = new int[] { 0x08, 0x10c8, 0x888 };
        public static int[] Invisibility = new int[] { 0x08, 0x2C };            // on 0x01 off 0x27

        public static int[] Seatbelt = new int[] { 0x08, 0x145C };
        public static int[] NoRagdoll = new int[] { 0x08, 0x10B8 };
        public static int[] NoCollision = new int[] { 0x08, 0x30, 0x10, 0x20, 0x70, 0x00, 0x2C };
    }

    public static int[] SpecialAmmo = new int[] { 0x08, 0x10C8, 0x218 };
    public static int[] NeverWanted = new int[] { 0x08, 0x10C8, 0x73C };
    public static int[] WantedCanChange = new int[] { 0x08, 0x10c8, 0x73C };
    public static int[] NPCIgnore = new int[] { 0x08, 0x10c8, 0x872 };      // 00 04 C3 C7

    public static int[] RpMultiplier = new int[] { 0x10 };
    public static int[] ApMultiplier = new int[] { 0x3188 };

    public static int[] OnlineListPlayerName = new int[] { 0x08, 0x10C8, 0xA4 };

    //public static int[] BunkerCargo = new int[] { 0x1180, 0x37D0 };
    //public static int[] BunkerDelivery = new int[] { 0x1180, 0x3F78 };
    //public static int[] BunkerDelivery_1 = new int[] { 0x1180, 0x46E0 };

    public static int[] RID = new int[] { 0x08, 0x10C8, 0x90 };

    public class Vehicle
    {
        public static int[] GodMode = new int[] { 0x08, 0xD30, 0x189 };
        public static int[] CurPassenger = new int[] { 0x08, 0xD30, 0xC62 };
        public static int[] Invisibility = new int[] { 0x08, 0xD30, 0x2C };            // on 0x01 off 0x27

        public static int[] Health = new int[] { 0x08, 0xD30, 0x280 };

        //public static int[] VehicleDrawHandler = new int[] { 0x08, 0xD30, 0x48 };
        //public static int[] Vehicle_EMS = new int[] { 0x08, 0xD30, 0x48, 0x3D6 };
        //public static int[] Vehicle_Brakes = new int[] { 0x08, 0xD30, 0x48, 0x3D7 };
        //public static int[] Vehicle_Transmission = new int[] { 0x08, 0xD30, 0x48, 0x3D8 };
        //public static int[] Vehicle_Horn = new int[] { 0x08, 0xD30, 0x48, 0x3D9 };
        //public static int[] Vehicle_Suspension = new int[] { 0x08, 0xD30, 0x48, 0x3DA };
        //public static int[] Vehicle_Armor = new int[] { 0x08, 0xD30, 0x48, 0x3DB };
        //public static int[] Vehicle_Turbo = new int[] { 0x08, 0xD30, 0x48, 0x3DD };
        //public static int[] Vehicle_Windows = new int[] { 0x08, 0xD30, 0x48, 0x3FF };

        public static int[] Extras = new int[] { 0x08, 0xD30, 0x20, 0x58B };
        public static int[] Parachute = new int[] { 0x08, 0xD30, 0x20, 0x58C };
    }

    public class Weapon
    {
        public static int[] AmmoInfo = new int[] { 0x08, 0x10D8, 0x20, 0x60 };
        public static int[] AmmoModifier = new int[] { 0x08, 0x10D0, 0x78 };

        public static int[] NoSpread = new int[] { 0x8, 0x10D8, 0x20, 0x74 };
        public static int[] NoRecoil = new int[] { 0x8, 0x10D8, 0x20, 0x2F4 };

        public static int[] ImpactType = new int[] { 0x08, 0x10D8, 0x20, 0x20 };
        public static int[] ImpactExplosion = new int[] { 0x08, 0x10D8, 0x20, 0x24 };

        public static int[] Range = new int[] { 0x08, 0x10D8, 0x20, 0x28C };
        public static int[] LockRange = new int[] { 0x08, 0x10D8, 0x20, 0x288 };

        public static int[] ReloadMult = new int[] { 0x08, 0x10D8, 0x20, 0x134 };
        public static int[] ReloadVehicleMult = new int[] { 0x08, 0x10D8, 0x20, 0x130 };

    }

    ////////////////////////////////////////////////////////////////////

    public static int[] PlayerVisualX = new int[] { 0x08, 0x90 };
    public static int[] PlayerVisualY = new int[] { 0x08, 0x94 };
    public static int[] PlayerVisualZ = new int[] { 0x08, 0x98 };

    public static int[] PlayerPositionX = new int[] { 0x08, 0x30, 0x50 };
    public static int[] PlayerPositionY = new int[] { 0x08, 0x30, 0x54 };
    public static int[] PlayerPositionZ = new int[] { 0x08, 0x30, 0x58 };

    public static int[] PlayerSin = new int[] { 0x08, 0x30, 0x20 };
    public static int[] PlayerCos = new int[] { 0x08, 0x30, 0x30 };

    public static int[] InVehicle = new int[] { 0x08, 0x14C7 };       // byte 0x10:false 0x00:true
    public static int[] PlayerWaterProof = new int[] { 0x08, 0x188 };

    // 角色在载具中，坐标偏移多了个pCVehicle = 0xD30
    public static int[] VehicleVisualX = new int[] { 0x08, 0xD30, 0x90 };
    public static int[] VehicleVisualY = new int[] { 0x08, 0xD30, 0x94 };
    public static int[] VehicleVisualZ = new int[] { 0x08, 0xD30, 0x98 };

    public static int[] VehiclePositionX = new int[] { 0x08, 0xD30, 0x30, 0x50 };
    public static int[] VehiclePositionY = new int[] { 0x08, 0xD30, 0x30, 0x54 };
    public static int[] VehiclePositionZ = new int[] { 0x08, 0xD30, 0x30, 0x58 };

    ////////////////////////////////////////////////////////////////////

    public static int[] ViewAngles_FPP_CosYaw = new int[] { 0x0, 0x3c0, 0x40 };
    public static int[] ViewAngles_FPP_SinYaw = new int[] { 0x0, 0x3c0, 0x44 };
    public static int[] ViewAngles_FPP_SinPitch = new int[] { 0x0, 0x3c0, 0x48 };

    public static int[] Crosshair_Location_X = new int[] { 0x0, 0x3c0, 0x60 };
    public static int[] Crosshair_Location_Y = new int[] { 0x0, 0x3c0, 0x64 };
    public static int[] Crosshair_Location_Z = new int[] { 0x0, 0x3c0, 0x68 };

    public static int[] ViewAngles_TPS_CosYaw = new int[] { 0x0, 0x3c0, 0x3D0 };
    public static int[] ViewAngles_TPS_SinYaw = new int[] { 0x0, 0x3c0, 0x3D4 };
    public static int[] ViewAngles_TPS_SinPitch = new int[] { 0x0, 0x3c0, 0x3D8 };

    public static int[] Crosshair_TPP_Location_X = new int[] { 0x0, 0x3c0, 0x3F0 };
    public static int[] Crosshair_TPP_Location_Y = new int[] { 0x0, 0x3c0, 0x3F4 };
    public static int[] Crosshair_TPP_Location_Z = new int[] { 0x0, 0x3c0, 0x3F8 };

    public static int[] Fov_Zoom = new int[] { 0x0, 0x3c0, 0x10, 0x30 };
}