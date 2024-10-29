namespace BTCPayApp.CommonServer
{
    public class AuthenticationSchemes
    {
        public const string Cookie = "Identity.Application";
        public const string Bitpay = "Bitpay";
        public const string Greenfield = "Greenfield.APIKeys,Greenfield.Basic,Greenfield.Bearer";
        public const string GreenfieldAPIKeys = "Greenfield.APIKeys";
        public const string GreenfieldBasic = "Greenfield.Basic";
        public const string GreenfieldBearer = "Greenfield.Bearer";
    }
}