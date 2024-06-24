namespace Aogami.SMTV.SaveData
{
    public static class SMTVGameSaveDataOffsets
    {
        static int addoff = 204;
        static int demonoff = 0xec;
        static int demonstatoff = 168;
        // Protagonist Name
        public static int FirstName = 1036+addoff;
        public static int FirstName2 = 2308+addoff;
        public static int FirstName3 = 2352 + addoff;
        public static int LastName = 2332 + addoff;
        public static int FullName = 2372 + addoff; // FirstName {space} LastName

        // Title
        public static int NahobinoTitleLevel = 1084 + addoff; // int
        public static int DemonTitleId = 1088 + addoff; //int. There are two more.
        public static int DemonTitleLevel = 1092 + addoff; //int. There are two more.

        // General
        public static int DateSaved = 1064 + addoff; // long
        public static int GameDifficulty = 1072 + addoff;
        public static int PlayTime = 1073 + addoff; // in seconds (int). It seems this is what's shown in the file select.
        public static int PlayTime2 = 1284 + addoff; // in seconds (int). It seems this is where the game's stopwatch picks from
        public static int Macca = 12144 + addoff;
        public static int Glory = 12168 + addoff;

        // Miracles
        public static int MiracleOffset = 12172 + addoff; // byte (0 to 255)

        // Items
        public static int ItemOffset = 13216 + addoff; // byte (0 to 255)

        // Nahobino Stats
        // Some of these are what's shown in the file select screen, others may be "Current Stat/Max Stat" and be shared space with rest of demons. (Investigate) 
        public static int NahobinoExp = 1348 + addoff; // int
        public static int NahobinoExp2 = 1820 + addoff; // int
        public static int NahobinoExp3 = 2292 + addoff; // int
        public static int NahobinoLevel = 1356 + addoff; // short
        public static int NahobinoLevel2 = 1828 + addoff; // short. It seems this is the level that's shown in file select?
        public static int NahobinoLevel3 = 2300 + addoff; // short. It seems this is what's shown in party thumbnail.
        public static int NahobinoHp = 2236 + addoff; // short
        public static int NahobinoHp2 = 2268 + addoff; // short
        public static int NahobinoHp3 = 2288 + addoff; // short
        public static int NahobinoMp = 2238 + addoff; // short
        public static int NahobinoMp2 = 2270 + addoff; // short
        public static int NahobinoMp3 = 2290 + addoff; // short
        public static int NahobinoStrength = 2240 + addoff; // short
        public static int NahobinoStrength2 = 2256 + addoff; // short
        public static int NahobinoStrength3 = 2272 + addoff; // short
        public static int NahobinoVitality = 2242 + addoff; // short
        public static int NahobinoVitality2 = 2258 + addoff; // short
        public static int NahobinoVitality3 = 2274 + addoff; // short
        public static int NahobinoMagic = 2244 + addoff; // short
        public static int NahobinoMagic2 = 2260 + addoff; // short
        public static int NahobinoMagic3 = 2276 + addoff; // short
        public static int NahobinoAgility = 2246 + addoff; // short
        public static int NahobinoAgility2 = 2262 + addoff; // short
        public static int NahobinoAgility3 = 2278 + addoff; // short
        public static int NahobinoLuck = 2248 + addoff; // short
        public static int NahobinoLuck2 = 2264 + addoff; // short
        public static int NahobinoLuck3 = 2280 + addoff; // short
        public static int NahobinoSkillId = 2416 + addoff; // short? +8

        // Demon Stats. +392
        public static int DemonExp = 0xBC8; // int
        public static int DemonLevel = 0xBD0; // short
        public static int DemonId = 0xBD2; // short
        public static int DemonHpBase = 0xB60; // short
        public static int DemonHpBalm = 0xB70; // short
        public static int DemonHpTotal = 0xB80; // short
        public static int DemonMpBase = 0xB62; // short
        public static int DemonMpBalm = 0xB72; // short
        public static int DemonMpTotal = 0xB82; // short
        public static int DemonStrength = 0xB64; // short
        public static int DemonStrength2 = 0xB74; // short
        public static int DemonStrength3 = 0xB84; // short
        public static int DemonVitality = 0xB66; // short
        public static int DemonVitality2 = 0xB76; // short
        public static int DemonVitality3 = 0xB86; // short
        public static int DemonMagic = 0xB68; // short
        public static int DemonMagic2 = 0xB78; // short
        public static int DemonMagic3 = 0xB88; // short
        public static int DemonAgility = 0xB6A; // short
        public static int DemonAgility2 = 0xB7A; // short
        public static int DemonAgility3 = 0xB8A; // short
        public static int DemonLuck = 0xB6C; // short
        public static int DemonLuck2 = 0xB7C; // short
        public static int DemonLuck3 = 0xB8C; // short
        public static int DemonSkillId = 2800 + demonoff; // short? +8
    }
}
