namespace BaristaLabs.ChromeDevTools.Runtime
{
    /// <summary>
    /// Represents a command used by the Chrome Remote Interface
    ///</summary>
    public interface ICommand<T>
        where T : ICommandResponse
    {
        /// <summary>
        /// Gets the name of the command.
        /// </summary>
        string CommandName
        {
            get;
        }
    }

    /// <summary>
    /// Represents a response to a command submitted by the Chrome Remote Interface
    ///</summary>
    public interface ICommandResponse
    {
    }
}