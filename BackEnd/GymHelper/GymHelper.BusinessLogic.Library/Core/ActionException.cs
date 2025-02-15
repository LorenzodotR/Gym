namespace GymHelper.BusinessLogic.Core
{
    public class ActionException : Exception
    {
        public ActionException(string message, int code, bool log = false) : base(message)
        {
            Code = code;
            Log = log;
        }

        public int Code { get; }
        public bool Log { get; }
    }
}
