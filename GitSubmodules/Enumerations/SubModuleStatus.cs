﻿namespace GitSubmodules.Enumerations
{
    /// <summary>
    /// Enumeration that contains all supported git submodules states of this application
    /// </summary>
    public enum SubModuleStatus
    {
        /// <summary>
        /// Indicate that the submodule has a unknown status
        /// </summary>
        Unknown,

        /// <summary>
        /// Indicate that the submodule is not registered
        /// </summary>
        NotRegistered,

        /// <summary>
        /// Indicate that the submodule is registered
        /// </summary>
        Registered,

        /// <summary>
        /// Indicate that the submodule has merge conflicts
        /// </summary>
        MergeConflict,

        /// <summary>
        /// Indicate that current SHA1-Checksum from the submodule and the entry are the same
        /// </summary>
        Current,

        /// <summary>
        /// Indicate that current SHA1-Checksum from the submodule and the entry are different
        /// </summary>
        NotCurrent
    }
}
