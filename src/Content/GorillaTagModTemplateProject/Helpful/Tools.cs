namespace GorillaTagModTemplateProject.Helpful
{
    public static class Tools
    {
        public static float NormalizeAngle(float a)
        {
            while (a > 180f) a -= 360f;
            while (a <= -180f) a += 360f;
            return a;
        }
    }
}
