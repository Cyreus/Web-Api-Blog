namespace WebUygulaması.Helpers
{
    public static class JwtExtension
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Accsess-Control-Allow-Origin","*");
            response.Headers.Add("Accsess-Control-Expose-Header", "Application-Error");


        }
    }
}
