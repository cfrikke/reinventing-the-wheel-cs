﻿using System;
class Program{
public static class StringUtils
{
    public static string ToUpper(string s) //Lower Case to upper case (string  ----> STRING)
    {
        string outcome = "";

        for (int i = 0; i < s.Length; i++)
        {
            
            if (s[i]>= 'a' && s[i] <= 'z')
            {
                
                outcome += (char)(s[i] - 32); // Turns Lower to Upper
            }
            else
            {
                outcome += s[i]; 
            }
        }

        return outcome;
    }
    public static string MirrorImage(string s)
    {
        string outcome ="";// Mirror Image starts here (Zoe -----> eoZ)
        for (int i = s.Length - 1 > 0; i--)
        {
            
        }
    }
}
}