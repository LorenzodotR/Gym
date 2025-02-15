namespace CoworkingManager.BusinessLogic.Core
{
    public static class ActionExceptionCodes
    {
        /* General */
        public static int InvalidRequest = -3;
        public static int ActionTimeout = -4;
        public static int AccessDenied = -5;
        public static int UserNotSet = -6;

        /* User */
        public static int UserNotFound = -100;
        public static int RoleNotFound = -101;
        public static int InvalidPassword = -103;
        public static int EmailAlreadyExists = -104;

        /* Coworking */
        public static int CoworkingNotFound = -200;

        /* Meeting */
        public static int MeetingConflict = -300;
        public static int RoomNotAvailableOnSunday = -301;
        public static int RoomNotAvailableOnSaturday = -302;
        public static int NumberOfUsersBiggerThanCapacity = -303;
        public static int InvalidStartTime = -304;
        public static int InvalidEndTime = -305;

        /* Page */
        public static int PageNotFound = -400;

        /* Game */
        public static int InvalidNumberOfPlayers = -500;
        public static int DuplicatedPlayer = -501;
        public static int InvalidPlayer = -502;
        public static int InvalidTeam = -503;
        public static int MatchAlreadyEvaluated = -504;
        public static int MatchTooOldToDelete = -505;
    }
}
