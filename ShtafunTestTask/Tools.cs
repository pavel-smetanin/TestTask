namespace ShtafunTestTask
{
    internal static class Tools
    {
        public static float GetPropCoef(int height, int width)
        {
            return (float)height / (float)width;
        }
        public static int GetPropHeight(int width, float propCoef)
        {
            return (int)Math.Ceiling(width * propCoef);
        }
        public static int GetPropWidth(int height, float propCoef)
        {
            return (int)Math.Ceiling(height / propCoef);
        }
    }
}
