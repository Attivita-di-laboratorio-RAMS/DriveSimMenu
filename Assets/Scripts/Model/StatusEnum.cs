namespace Model
{
    /// <summary>
    /// Enumeration representing the possible states of the machine.
    /// </summary>
    public enum StatusEnum
    {   
        Initializing,
        Homing,
        Ready,
        
        Starting,
        Running,
        
        Pausing,
        Paused,
        
        Stopping,
        Stopped,
        
        Error
    }
}