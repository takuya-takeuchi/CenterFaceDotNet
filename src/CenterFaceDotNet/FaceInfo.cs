namespace CenterFaceDotNet
{

    /// <summary>
    /// Describes the location of a face. This class cannot be inherited.
    /// </summary>
    public sealed class FaceInfo
    {

        #region Properties

        /// <summary>
        /// Gets the x-axis value of the left side of the rectangle of face.
        /// </summary>
        public float X1
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the y-axis value of the top of the rectangle of face.
        /// </summary>
        public float Y1
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the x-axis value of the right side of the rectangle of face.
        /// </summary>
        public float X2
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the y-axis value of the bottom of the rectangle of face.
        /// </summary>
        public float Y2
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the score of the rectangle of face.
        /// </summary>
        public float Score
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the area of the rectangle of face.
        /// </summary>
        public float Area
        {
            get;
            internal set;
        }

        /// <summary>
        /// Gets the face parts locations (eyes, nose, etc).
        /// </summary>
        public float[] Landmarks
        {
            get;
        } = new float[10];

        #endregion

    }

}