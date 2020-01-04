namespace CenterFaceDotNet
{

    public sealed class FaceInfo
    {

        #region Properties

        public float X1
        {
            get;
            internal set;
        }

        public float Y1
        {
            get;
            internal set;
        }

        public float X2
        {
            get;
            internal set;
        }

        public float Y2
        {
            get;
            internal set;
        }

        public float Score
        {
            get;
            internal set;
        }

        public float Area
        {
            get;
            internal set;
        }

        public float[] Landmarks
        {
            get;
        } = new float[10];

        #endregion

    }

}