﻿namespace Portalum.Zvt
{
    /// <summary>
    /// CommandResponse
    /// </summary>
    public class CommandResponse
    {
        /// <summary>
        /// State
        /// </summary>
        public CommandResponseState State { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string ErrorMessage { get; set; }

        public byte[]  CompletionBytes { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.ErrorMessage))
            {
                return $"State:{this.State}";
            }

            return $"State:{this.State} ErrorMessage:{this.ErrorMessage}";
        }
    }
}
