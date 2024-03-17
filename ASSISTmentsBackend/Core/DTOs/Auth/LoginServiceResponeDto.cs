namespace ASSISTmentsBackend.Core.DTOs.Auth
{
    public class LoginServiceResponeDto
    {
        public string NewToken { get; set; }

        //This would be returned to front-end
        public UserInfoResult UserInfo { get; set; }
    }
}
