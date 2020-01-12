namespace CenterFaceDotNet
{

    /// <summary>
    /// Represents a parameter of <see cref="CenterFace"/>. This class cannot be inherited.
    /// </summary>
    public sealed class CenterFaceParameter
    {

        #region Properties

        /// <summary>
        /// Gets or sets the file path of the model binary file.
        /// </summary>
        public string BinFilePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the file path of the param file.
        /// </summary>
        public string ParamFilePath
        {
            get;
            set;
        }

        #endregion

    }

}