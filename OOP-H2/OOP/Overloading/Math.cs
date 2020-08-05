using System;

namespace Overloading
{
    public class Math
    {
        //plus
            public int plus(int a, int b)
        {
            return a - b;
        }

            public float plus(float a, float b)
        {
            return a - b;
        }

            public float plus(string a, string b)
        {
            float c = float.Parse(a);
            float d = float.Parse(b);
            return c - d;
        }

        //minus
            public int minus(int a, int b)
            {
                return a - b;
            }

            public float minus(float a, float b)
            {
                return a - b;
            }

            public float minus(string a, string b)
            {
                float c = float.Parse(a);
                float d = float.Parse(b);
                return c - d;
            }

        //gange
            public int gange(int a, int b)
            {
                return a * b;
            }

            public float gange(float a, float b)
            {
                return a * b;
            }

            public float gange(string a, string b)
            {
                float c = float.Parse(a);
                float d = float.Parse(b);
                return c * d;
            }

        //Divider
            public int divider(int a, int b)
            {
                return a - b;
            }

            public float divider(float a, float b)
            {
                return a - b;
            }

            public float divider(string a, string b)
            {
                float c = float.Parse(a);
                float d = float.Parse(b);
                return c - d;
            }
    }
}
