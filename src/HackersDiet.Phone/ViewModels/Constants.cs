﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace HackersDiet.Phone.ViewModels
{
    public class Constants
    {
        public static int[] Rungs = new int[48] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48 };
        public static int[] Bends = new int[48] { 2, 3, 4, 6, 7, 8, 10, 12, 14, 16, 18, 20, 23, 25, 28, 14, 15, 16, 18, 19, 21, 22, 24, 25, 27, 29, 31, 33, 34, 36, 38, 40, 43, 45, 47, 49, 51, 54, 56, 59, 61, 66, 66, 69, 72, 74, 77, 80 };
        public static int[] SitUps = new int[48] { 3, 4, 6, 7, 9, 10, 11, 13, 15, 16, 18, 20, 21, 23, 25, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 21, 23, 24, 26, 28, 29, 31, 33, 35, 37, 39, 41, 43, 46, 48, 50, 53, 55, 58, 61, 64, 66, 69 };
        public static int[] LegLifts = new int[48] { 4, 5, 6, 8, 9, 10, 12, 14, 16, 18, 20, 22, 25, 27, 30, 12, 14, 16, 17, 19, 21, 23, 25, 27, 29, 31, 33, 36, 38, 40, 43, 45, 48, 51, 54, 56, 59, 62, 65, 68, 72, 75, 78, 81, 85, 88, 92, 96 };
        public static int[] PushUps = new int[48] { 2, 3, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13, 15, 16, 18, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41 };
        public static int[] Steps = new int[48] { 105, 140, 170, 200, 225, 255, 280, 305, 325, 350, 370, 390, 405, 425, 440, 340, 355, 375, 390, 405, 420, 435, 445, 460, 470, 480, 490, 500, 510, 515, 525, 530, 535, 540, 540, 545, 545, 545, 550, 555, 555, 555, 560, 560, 560, 575, 575, 575 };
        public static int[] Counts = new int[48] { 1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 4, 4, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
        public static int[] Remainders = new int[48] { 30, 65, 20, 50, 0, 30, 55, 5, 25, 50, 70, 15, 30, 50, 65, 40, 55, 0, 15, 30, 45, 60, 70, 10, 20, 30, 40, 50, 60, 65, 0, 5, 10, 15, 15, 20, 20, 20, 25, 30, 30, 30, 35, 35, 35, 50, 50, 50 };

    }
}