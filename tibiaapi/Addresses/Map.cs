namespace Tibia.Addresses
{
    /// <summary>
    /// Map memory addresses.
    /// </summary>
    public static class Map
    {
        /// <summary>
        /// Pointer to the start of the map memory addresses.
        /// </summary>
        public static uint MapPointer = 0x631610;     //8.1, 8.0 = 0x61E408

        /// <summary>
        /// Step between squares on the map.
        /// </summary>
        public static uint Step_Square = 172;          //8.0

        /// <summary>
        /// Step between objects on a square.
        /// The first object is the tile, subsequent objects are any nonmoveable items (trees),
        /// creatures (players), or items in that tile.
        /// </summary>
        public static uint Step_Square_Object = 12;

        /// <summary>
        /// Distance from the square to the number of objects on the square.
        /// </summary>
        public static uint Distance_Square_ObjectCount = 0;

        /// <summary>
        /// Distance to the first object on a square.
        /// </summary>
        public static uint Distance_Square_Objects = 4;

        /// <summary>
        /// Distance to the id of the object that is on a square.
        /// </summary>
        public static uint Distance_Object_Id = 0;        //8.0
        /// <summary>
        /// Distance to the data of the object that is on a square.
        /// </summary>
        public static uint Distance_Object_Data = 4;      //8.0
        /// <summary>
        /// Distance to the ExData (extra data) of the object that is on a square.
        /// </summary>
        public static uint Distance_Object_Data_Ex = 8;   //8.0

        /// <summary>
        /// Maximum number of objects per tile.
        /// </summary>
        public static uint Max_Square_Objects = 13;

        /// <summary>
        /// Maximum number of tiles in the X direction
        /// </summary>
        public static uint Max_X = 18;

        /// <summary>
        /// Maximum number of tiles in the Y direction
        /// </summary>
        public static uint Max_Y = 14;

        /// <summary>
        /// Maximum number of tiles in the Z direction
        /// </summary>
        public static uint Max_Z = 8;

        /// <summary>
        /// Maximum number of tiles.
        /// </summary>
        public static uint Max_Squares = 2016; // Max_X * Max_Y * Max_Z

        /// <summary>
        /// The default (starting) Z axis value
        /// </summary>
        public static uint Z_Axis_Default = 7; // default ground level

        /// <summary>
        /// Memory address for player tile
        /// </summary>
        public static uint Player_Tile = 0x3E3A08; // 8.1
        /// <summary>
        /// Nop Value, to use with namespy and levelspy
        /// </summary>
        public static byte[] Nops = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };

        /// <summary>
        /// NameSpy address 1.
        /// </summary>
        public static uint NameSpy1 = 0x4E7A09; // 8.2

        /// <summary>
        /// NameSpy address 2.
        /// </summary>
        public static uint NameSpy2 = 0x004E7A13; // 8.2

        /// <summary>
        /// Default value for Namespy1.
        /// </summary>
        public static uint NameSpy1Default = 19061; //8.2
        /// <summary>
        /// Default value for Namespy2.
        /// </summary>
        public static uint NameSpy2Default = 16501; //8.2

        /// <summary>
        /// Level spy address 1.
        /// </summary>
        public static uint LevelSpy1 = 0x4E974A; //8.2

        /// <summary>
        /// Level spy address 2.
        /// </summary>
        public static uint LevelSpy2 = 0x4E984F; //8.2

        /// <summary>
        /// Level spy address 3.
        /// </summary>
        public static uint LevelSpy3 = 0x4E98D0; //8.2

        /// <summary>
        /// Level spy pointer.
        /// </summary>
        public static uint LevelSpyPtr = 0x629754; //8.2

        /// <summary>
        /// Defaults for level spy.
        /// </summary>
        public static byte[] LevelSpyDefault = { 0x89, 0x86, 0xD8, 0x25, 0x00, 0x00 };
        /// <summary>
        /// Level spy add 1.
        /// </summary>
        public static byte LevelSpyAdd1 = 28;
        /// <summary>
        /// Level spy add 2.
        /// </summary>
        public static uint LevelSpyAdd2 = 0x25D8; //8.2

        /// <summary>
        /// Write to this byte to reveal invisible creatures.
        /// Thanks to Stiju @ http://www.tpforums.org/forum/showthread.php?t=1141
        /// </summary>
        public static uint RevealInvisible1 = 0x45B5D3; //8.?
        public static byte RevealInvisible1Default = 0x72;
        public static byte RevealInvisible1Edited = 0xEB;
        public static uint RevealInvisible2 = 0x4E6CD4; //8.?
        public static byte RevealInvisible2Default = 0x75;
        public static byte RevealInvisible2Edited = 0xEB;
    }
}
