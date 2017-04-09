namespace BaristaLabs.ChromeDevTools.Runtime
{
    public static class ICommandResponseExtensions
    {
        public static TCommandResponse GetResponse<TCommandResponse>(this ICommandResponse response)
            where TCommandResponse : class, ICommandResponse
        {
            return response as TCommandResponse;
        }
    }
}
