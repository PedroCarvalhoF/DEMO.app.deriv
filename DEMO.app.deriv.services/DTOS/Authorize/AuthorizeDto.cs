namespace DEMO.app.deriv.services.DTOS.Authorize
{
    public class AuthorizeDto
    {
        public string email { get; set; }
        public decimal balance { get; set; }
        public string authorize { get; set; }
        public string fullname { get; internal set; }
        public string loginid { get; internal set; }

        public AuthorizeDto()
        {

        }

        AuthorizeDto(string authorize)
        {
            this.authorize = authorize;
        }
        public static AuthorizeDto SetToken(string token)
            => new AuthorizeDto(token);
    }
}
