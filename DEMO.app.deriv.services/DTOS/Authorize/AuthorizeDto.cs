namespace DEMO.app.deriv.services.DTOS.Authorize
{
    public class AuthorizeDto
    {
        public string authorize { get; private set; }

        AuthorizeDto(string authorize)
        {
            this.authorize = authorize;
        }
        public static AuthorizeDto SetToken(string token)
            => new AuthorizeDto(token);
    }
}
