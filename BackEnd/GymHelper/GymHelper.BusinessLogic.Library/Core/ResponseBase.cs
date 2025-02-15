using GymHelper.Model;

namespace GymHelper.BusinessLogic.Core
{
    public class ResponseBase
    {
        public bool Succeeded { get; set; } = true;
        public Error Error { get; set; }
    }
}