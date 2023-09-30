﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace tyuiu.cources.programming
{
    public class TestingDataController
    {
        private Dictionary<Type, (object result, object[] args)> testData = new()
        {
            //Sprint1

            //Task0

            { typeof(ISprint1Task0V1), (-6.0, new object[] {})},
            { typeof(ISprint1Task0V2), (1.0, new object[] {})},
            { typeof(ISprint1Task0V3), (1.0, new object[] {})},
            { typeof(ISprint1Task0V4), (6.0, new object[] {})},
            { typeof(ISprint1Task0V5), (12.0, new object[] {})},
            { typeof(ISprint1Task0V6), (15.0, new object[] {})},
            { typeof(ISprint1Task0V7), (5.0, new object[] {})},
            { typeof(ISprint1Task0V8), (1.875, new object[] {})},
            { typeof(ISprint1Task0V9), (3.0, new object[] {})},
            { typeof(ISprint1Task0V10), (-10.5, new object[] {})},
            { typeof(ISprint1Task0V11), (7.0, new object[] {})},
            { typeof(ISprint1Task0V12), (6.0, new object[] {})},
            { typeof(ISprint1Task0V13), (1.0, new object[] {})},
            { typeof(ISprint1Task0V14), (25.0, new object[] {})},
            { typeof(ISprint1Task0V15), (24.0, new object[] {})},
            { typeof(ISprint1Task0V16), (-7.0, new object[] {})},
            { typeof(ISprint1Task0V17), (5.0, new object[] {})},
            { typeof(ISprint1Task0V18), (3.0, new object[] {})},
            { typeof(ISprint1Task0V19), (10.0, new object[] {})},
            { typeof(ISprint1Task0V20), (13.0, new object[] {})},
            { typeof(ISprint1Task0V21), (17.0, new object[] {})},
            { typeof(ISprint1Task0V22), (10.0, new object[] {})},
            { typeof(ISprint1Task0V23), (13.0, new object[] {})},
            { typeof(ISprint1Task0V24), (2.0, new object[] {})},
            { typeof(ISprint1Task0V25), (3.0, new object[] {})},
            { typeof(ISprint1Task0V26), (7.0, new object[] {})},
            { typeof(ISprint1Task0V27), (22.0, new object[] {})},
            { typeof(ISprint1Task0V28), (2.0, new object[] {})},
            { typeof(ISprint1Task0V29), (32.0, new object[] {})},
            { typeof(ISprint1Task0V30), (96.0, new object[] {})},

            //Task1
          
            { typeof(ISprint1Task1V0), (2.0, new object[] {1, 9})},
            { typeof(ISprint1Task1V1), (7.5, new object[] {9, 2, 1})},
            { typeof(ISprint1Task1V2), (0.5, new object[] {5, 1})},
            { typeof(ISprint1Task1V3), (3.0, new object[] {2, 2})},
            { typeof(ISprint1Task1V4), (4.0, new object[] {2, 2})},
            { typeof(ISprint1Task1V5), (8.0, new object[] {3, 3})},
            { typeof(ISprint1Task1V6), (2.0, new object[] {5, 1})},
            { typeof(ISprint1Task1V7), (2.5, new object[] {2, 2})},
            { typeof(ISprint1Task1V8), (3.14, new object[] {2, 2})},
            { typeof(ISprint1Task1V9), (0.875, new object[] {2, 2})},
            { typeof(ISprint1Task1V10), (1.0, new object[] {1, 1})},
            { typeof(ISprint1Task1V11), (5.0, new object[] {6, 1})},
            { typeof(ISprint1Task1V12), (1.0, new object[] {3, 3})},
            { typeof(ISprint1Task1V13), (2.0, new object[] {10})},
            { typeof(ISprint1Task1V14), (3.25, new object[] {1, 3, 1})},
            { typeof(ISprint1Task1V15), (2.0, new object[] {5})},
            { typeof(ISprint1Task1V16), (22.0, new object[] {2, 2, 1})},
            { typeof(ISprint1Task1V17), (12.0, new object[] {2, 2})},
            { typeof(ISprint1Task1V18), (-1.0, new object[] {2, 3})},
            { typeof(ISprint1Task1V19), (5.5, new object[] {2, 2})},
            { typeof(ISprint1Task1V20), (12.0, new object[] {2, 2})},
            { typeof(ISprint1Task1V21), (0.8, new object[] {2, 2})},
            { typeof(ISprint1Task1V22), (1.75, new object[] {2, 2})},
            { typeof(ISprint1Task1V23), (1.57, new object[] {2, 2})},
            { typeof(ISprint1Task1V24), (-0.25, new object[] {2, 2})},
            { typeof(ISprint1Task1V25), (0.5, new object[] {2, 2})},
            { typeof(ISprint1Task1V26), (2.5, new object[] {2, 2})},
            { typeof(ISprint1Task1V27), (2.0, new object[] {2, 2})},
            { typeof(ISprint1Task1V28), (1.5, new object[] {3})},
            { typeof(ISprint1Task1V29), (0.8, new object[] {2, 2, 1})},
            { typeof(ISprint1Task1V30), (2.0, new object[] {2})},

            //Task2
          
            { typeof(ISprint1Task2V0), (2, new object[] {2})},
            { typeof(ISprint1Task2V1), (1000.0, new object[] {1609})},
            { typeof(ISprint1Task2V2), (3.142, new object[] {180})},
            { typeof(ISprint1Task2V3), (360, new object[] {6})},
            { typeof(ISprint1Task2V4), (36, new object[] {6})},
            { typeof(ISprint1Task2V5), (216, new object[] {6})},
            { typeof(ISprint1Task2V6), (0.006, new object[] {6})},
            { typeof(ISprint1Task2V7), (113.097, new object[] {6})},
            { typeof(ISprint1Task2V8), (18, new object[] {6, 3})},
            { typeof(ISprint1Task2V9), (678.584, new object[] {6})},
            { typeof(ISprint1Task2V10), (236.22, new object[] {6})},
            { typeof(ISprint1Task2V11), (21780, new object[] {6, 3})},
            { typeof(ISprint1Task2V12), (36, new object[] {6, 2, 3})},
            { typeof(ISprint1Task2V13), (9.656, new object[] {6})},
            { typeof(ISprint1Task2V14), (283, new object[] {556})},
            { typeof(ISprint1Task2V15), (216, new object[] {6})},
            { typeof(ISprint1Task2V16), (37.699, new object[] {6})},
            { typeof(ISprint1Task2V17), (2, new object[] {120})},
            { typeof(ISprint1Task2V18), (32, new object[] {6, 2, 2})},
            { typeof(ISprint1Task2V19), (0.584, new object[] {23})},
            { typeof(ISprint1Task2V20), (45, new object[] {6, 3})},
            { typeof(ISprint1Task2V21), (18, new object[] {6, 3})},
            { typeof(ISprint1Task2V22), (4, new object[] {6, 3, 3})},
            { typeof(ISprint1Task2V23), (360, new object[] {6})},
            { typeof(ISprint1Task2V24), (9, new object[] {6, 3})},
            { typeof(ISprint1Task2V25), (343.775, new object[] {6})},
            { typeof(ISprint1Task2V26), (363, new object[] {6, 3})},
            { typeof(ISprint1Task2V27), (24, new object[] {6})},
            { typeof(ISprint1Task2V28), (279, new object[] {6})},
            { typeof(ISprint1Task2V29), (10, new object[] {600})},
            { typeof(ISprint1Task2V30), (8900.0, new object[] {8.9})},
           

            //Task3

            { typeof(ISprint1Task3V0), (2.0, new object[] {1, 1})},
            { typeof(ISprint1Task3V1), (6.283, new object[] {1, 2})},
            { typeof(ISprint1Task3V2), (11.0, new object[] {1, 5, 3, 2})},
            { typeof(ISprint1Task3V3), (3.0, new object[] {1, 1, 3})},
            { typeof(ISprint1Task3V4), (4.0, new object[] {1, 1, 2})},
            { typeof(ISprint1Task3V5), (1.0, new object[] {1, 1})},
            { typeof(ISprint1Task3V6), (0.1, new object[] {1, 1, 5})},
            { typeof(ISprint1Task3V7), (5.334, new object[] {5})},
            { typeof(ISprint1Task3V8), (54.795,new object[] {5000, 10, 40})},
            { typeof(ISprint1Task3V9), (3.0, new object[] {200})},
            { typeof(ISprint1Task3V10), (30.5, new object[] {30.5})},
            { typeof(ISprint1Task3V11), (19.0, new object[] {-2, 5, 1, 7, 5, -3})},
            { typeof(ISprint1Task3V12), (72.0, new object[] {12, 12})},
            { typeof(ISprint1Task3V13), (6.0, new object[] {123})},
            { typeof(ISprint1Task3V14), (321.0, new object[] {123})},
            { typeof(ISprint1Task3V15), (15.0, new object[] {1, 5, 3, 2})},
            { typeof(ISprint1Task3V16), (-2.0, new object[] {1, 1})},
            { typeof(ISprint1Task3V17), (true, new object[] {150.150})},
            { typeof(ISprint1Task3V18), (9.0, new object[] {9, 9, 3})},
            { typeof(ISprint1Task3V19), (true, new object[] {5, 1, 5, 1})},

            //Task4

            { typeof(ISprint1Task4V0), (2.000, new object[] {1 , 1 })},
            { typeof(ISprint1Task4V1), (1.000, new object[] {-1 })},
            { typeof(ISprint1Task4V2), (0.500, new object[] {2 , 1 })},
            { typeof(ISprint1Task4V3), (0.750, new object[] {3 , 1 })},
            { typeof(ISprint1Task4V4), (0.750, new object[] {2 , 1 })},
            { typeof(ISprint1Task4V5), (0.250, new object[] {2 , 4 })},
            { typeof(ISprint1Task4V6), (0.050, new object[] {360 , 30 })},
            { typeof(ISprint1Task4V7), (0.187, new object[] {2 , 2 })},
            { typeof(ISprint1Task4V8), (-0.6, new object[] {-2 , 7 })},
            { typeof(ISprint1Task4V9), (0.039, new object[] {120 , 30 })},
            { typeof(ISprint1Task4V10), (0.512, new object[] {60 })},
            { typeof(ISprint1Task4V11), (0.009, new object[] {5 , 5 })},
            { typeof(ISprint1Task4V12), (0.4, new object[] {0.5 , 4 })},
            { typeof(ISprint1Task4V13), (-0.045, new object[] {1 , 1 })},
            { typeof(ISprint1Task4V14), (0.007, new object[] {5, 5 })},
            { typeof(ISprint1Task4V15), (2017.144, new object[] {1 , 2 })},
            { typeof(ISprint1Task4V16), (0.037, new object[] {23})},
            { typeof(ISprint1Task4V17), (0.115, new object[] {100 , 5 })},
            { typeof(ISprint1Task4V18), (0.005, new object[] {5 , 5 })},
            { typeof(ISprint1Task4V19), (1.14, new object[] {52 , 5 })},
            { typeof(ISprint1Task4V20), (2.549, new object[] {5 , 5 })},
            { typeof(ISprint1Task4V21), (41.011, new object[] {60, 30 })},
            { typeof(ISprint1Task4V22), (0.019, new object[] {0.5, 4 })},
            { typeof(ISprint1Task4V23), (0.096, new object[] {60, 30 })},
            { typeof(ISprint1Task4V24), (1.199, new object[] {60, 30 })},
            { typeof(ISprint1Task4V25), (0.551, new object[] {120 })},
            { typeof(ISprint1Task4V26), (-0.062, new object[] {1 , 1 })},
            { typeof(ISprint1Task4V27), (0.152, new object[] {8, 2 })},
            { typeof(ISprint1Task4V28), (0.368, new object[] {0, 1 })},
            { typeof(ISprint1Task4V29), (0.024, new object[] {10, 2 })},
            { typeof(ISprint1Task4V30), (10.0, new object[] {2, 2 })},

            //Task5

            { typeof(ISprint1Task5V0), (2.0, new object[] {1 , 1 })},
            { typeof(ISprint1Task5V1), (2, new object[] {5 , 3, 2, 1 })},
            { typeof(ISprint1Task5V2), (-15, new object[] {5 })},
            { typeof(ISprint1Task5V3), (5, new object[] {230598 })},
            { typeof(ISprint1Task5V4), (5, new object[] {20000})},
            { typeof(ISprint1Task5V5), (6, new object[] {50.699})},
            { typeof(ISprint1Task5V6), (5, new object[] {5})},
            { typeof(ISprint1Task5V7), (1, new object[] {45})},

            //Task6

            { typeof(ISprint1Task6V0), ("", new object[] {"" })},
            { typeof(ISprint1Task6V1), ("49", new object[] {"1" })},
            { typeof(ISprint1Task6V2), (true, new object[] {"Hello world" })},
            { typeof(ISprint1Task6V3), ("od", new object[] {"Hello world" })},
            { typeof(ISprint1Task6V4), ("желанный медленный", new object[] {"желанный юный медленный" })},
            { typeof(ISprint1Task6V5), ("шалаш", new object[] {"хороший шалаш" })},
            { typeof(ISprint1Task6V6), ("ривет ир", new object[] {"привет мир" })},
            { typeof(ISprint1Task6V7), ("привет ми", new object[] {"привет мир" })},
            { typeof(ISprint1Task6V8), ("риветп ирм", new object[] {"привет мир" })},
            { typeof(ISprint1Task6V9), ("тприве рми", new object[] {"привет мир" })},
            { typeof(ISprint1Task6V10), ("привет мр", new object[] {"привет мир" })},
            { typeof(ISprint1Task6V11), (false, new object[] {"привет мир" })},
            { typeof(ISprint1Task6V12), (true, new object[] {"привет мир мир" })},
            { typeof(ISprint1Task6V13), (true, new object[] {"абвгд" })},
            { typeof(ISprint1Task6V14), (true, new object[] {"строка" })},
            { typeof(ISprint1Task6V15), (true, new object[] {"привет!" })},
            { typeof(ISprint1Task6V16), (true, new object[] {"что?!" })},
            { typeof(ISprint1Task6V17), (true, new object[] {"шалаш" })},
            { typeof(ISprint1Task6V18), (true, new object[] {"122" })},

            //Task7

            { typeof(ISprint1Task7V0), (1.0, new object[] {2, 3, 1 })},
            { typeof(ISprint1Task7V1), (-28.579, new object[] {2, 4, 5 })},
            { typeof(ISprint1Task7V2), (-5.103, new object[] {2, 4})},
            { typeof(ISprint1Task7V3), (0.896, new object[] {2, 4 })},
            { typeof(ISprint1Task7V4), (0.236, new object[] {2, 4 })},
            { typeof(ISprint1Task7V5), (-0.544, new object[] {2, 4 })},
            { typeof(ISprint1Task7V6), (-188.000, new object[] {2, 4 })},
            { typeof(ISprint1Task7V7), (-6.641, new object[] {2, 4 })},
            { typeof(ISprint1Task7V8), (-9.676, new object[] {2, 4 })},
            { typeof(ISprint1Task7V9), (5.982, new object[] {2, 4 })},
            { typeof(ISprint1Task7V10), (6.398, new object[] {20, 20 })},
            { typeof(ISprint1Task7V11), (-3.472, new object[] {20, 1 })},
            { typeof(ISprint1Task7V12), (2257.594, new object[] {5, 5 })},
            { typeof(ISprint1Task7V13), (0.871, new object[] {1, 1 })},
            { typeof(ISprint1Task7V14), (-0.889, new object[] {5, 5 })},
            { typeof(ISprint1Task7V15), (96.484, new object[] {5 })},
            { typeof(ISprint1Task7V16), (0.026, new object[] {5 })},
            { typeof(ISprint1Task7V17), (0.087, new object[] {5, 5 })},
            { typeof(ISprint1Task7V18), (1.061, new object[] {1, 1 })},
            { typeof(ISprint1Task7V19), (2502.641, new object[] {5 })},
            { typeof(ISprint1Task7V20), (25.479, new object[] {5, 5 })},
            { typeof(ISprint1Task7V21), (-18.916, new object[] {2, 4})},
            { typeof(ISprint1Task7V22), (0.172, new object[] {2, 4 })},
            { typeof(ISprint1Task7V23), (-1.781, new object[] {2, 4 })},
            { typeof(ISprint1Task7V24), (0.016, new object[] {2, 4 })},
            { typeof(ISprint1Task7V25), (6.733, new object[] {2, 4 })},
            { typeof(ISprint1Task7V26), (0.753, new object[] {2, 4 })},
            { typeof(ISprint1Task7V27), (-3.597, new object[] {2, 4 })},
            { typeof(ISprint1Task7V28), (16.787, new object[] {2, 4 })},
            { typeof(ISprint1Task7V29), (2.071, new object[] {2, 4 })},
            { typeof(ISprint1Task7V30), (11.977, new object[] {2, 4 })},

            //Sprint 2

            //Task0

            { typeof(ISprint2Task0V0), (new object[6] {true, true, true, true, true, true }, new object[] {5, 6 })},
            { typeof(ISprint2Task0V1), (new object[6] {true, false, true, false, true, false }, new object[] {233, 122 })},
            { typeof(ISprint2Task0V2), (new object[6] {false, true, false, true, false, true }, new object[] {123, 123 })},
            { typeof(ISprint2Task0V3), (new object[6] {false, true, false, true, false, true }, new object[] {45, 127 })},
            { typeof(ISprint2Task0V4), (new object[6] {false, true, false, true, false, true }, new object[] {333, 324 })},
            { typeof(ISprint2Task0V5), (new object[6] {false, true, true, true, false, true }, new object[] {105, 223 })},
            { typeof(ISprint2Task0V6), (new object[6] {true, true, true, false, true, false }, new object[] {107, 754 })},
            { typeof(ISprint2Task0V7), (new object[6] {true, false, true, true, true, false }, new object[] {103, 475 })},
            { typeof(ISprint2Task0V8), (new object[6] {true, false, true, false, true, false }, new object[] {185, 251 })},
            { typeof(ISprint2Task0V9), (new object[6] {true, true, true, true, true, false }, new object[] {1054, 375 })},
            { typeof(ISprint2Task0V10), (new object[6] {false, true, false, true, false, true }, new object[] {1305, 475 })},
            { typeof(ISprint2Task0V11), (new object[6] {true, false, true, false, true, false }, new object[] {8105, 275 })},
            { typeof(ISprint2Task0V12), (new object[6] {true, false, true, false, true, false }, new object[] {1095, 475 })},
            { typeof(ISprint2Task0V13), (new object[6] {false, true, false, true, false, true }, new object[] {1905, 475 })},
            { typeof(ISprint2Task0V14), (new object[6] {true, false, true, false, true, false }, new object[] {1075, 754 })},
            { typeof(ISprint2Task0V15), (new object[6] {false, false, true, true, false, false }, new object[] {3105, 275 })},

            //Task1

            { typeof(ISprint2Task1V1), (new object[6] {true, false, true, false, true, false }, new object[] {119, 196, 134, 327 })},
            { typeof(ISprint2Task1V2), (new object[6] {true, true, true, true, true, false }, new object[] {135, 156, 154, 174 })},
            { typeof(ISprint2Task1V3), (new object[6] {true, false, false, false, false, false }, new object[] {185, 316, 134, 134 })},
            { typeof(ISprint2Task1V4), (new object[6] {false, false, false, false, true, false }, new object[] {175, 176, 414, 414 })},
            { typeof(ISprint2Task1V5), (new object[6] {true, false, false, false, true, false }, new object[] {154, 163, 134, 137 })},
            { typeof(ISprint2Task1V6), (new object[6] {false, false, true, false, true, false }, new object[] {915, 169, 174, 133 })},
            { typeof(ISprint2Task1V7), (new object[6] {true, false, false, false, true, false }, new object[] {195, 16, 14, 45 })},
            { typeof(ISprint2Task1V8), (new object[6] {true, false, true, false, false, false }, new object[] {15, 16, 14, 335 })},
            { typeof(ISprint2Task1V9), (new object[6] {false, false, true, false, true, false }, new object[] {15, 335, 174, 478 })},
            { typeof(ISprint2Task1V10), (new object[6] {true, false, false, false, true, false }, new object[] {455, 335, 14, 17 })},
            { typeof(ISprint2Task1V11), (new object[6] {false, false, true, false, true, false }, new object[] {145, 156, 142, 117 })},
            { typeof(ISprint2Task1V12), (new object[6] {true, true, true, false, true, false }, new object[] {152, 116, 887, 556 })},
            { typeof(ISprint2Task1V13), (new object[6] {true, true, true, true, true, false }, new object[] {145, 916, 164, 137 })},
            { typeof(ISprint2Task1V14), (new object[6] {false, true, true, true, true, false }, new object[] {185, 216, 174, 917 })},
            { typeof(ISprint2Task1V15), (new object[6] {true, false, false, false, false, true }, new object[] {415, 616, 134, 127 })},

            //Task2

            { typeof(ISprint2Task2V1), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V2), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V3), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V4), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V5), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V6), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V7), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V8), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V9), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V10), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V11), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V12), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V13), (true, new object[] {9, 6 })},
            { typeof(ISprint2Task2V14), (true, new object[] {9, 5 })},
            { typeof(ISprint2Task2V15), (true, new object[] {9, 6 })},
            
            //Task3

            { typeof(ISprint2Task3V1), (88.697, new object[] {5 })},
            { typeof(ISprint2Task3V2), (-54.716, new object[] {5 })},
            { typeof(ISprint2Task3V3), (37.969, new object[] {5 })},
            { typeof(ISprint2Task3V4), (12.594, new object[] {5 })},
            { typeof(ISprint2Task3V5), (-2.594, new object[] {5 })},
            { typeof(ISprint2Task3V6), (9, new object[] {5 })},
            { typeof(ISprint2Task3V7), (0.002, new object[] {-3 })},
            { typeof(ISprint2Task3V8), (-0.543, new object[] {5 })},
            { typeof(ISprint2Task3V9), (1, new object[] {0 })},
            { typeof(ISprint2Task3V10), (-1, new object[] {0 })},
            { typeof(ISprint2Task3V11), (5.186, new object[] {5 })},
            { typeof(ISprint2Task3V12), (12.594, new object[] {5 })},
            { typeof(ISprint2Task3V13), (-2.594, new object[] {5 })},
            { typeof(ISprint2Task3V14), (1.625, new object[] {5 })},
            { typeof(ISprint2Task3V15), (12.594, new object[] {5 })},

            //Task4

            { typeof(ISprint2Task4V1), (1.429, new object[] {9, 4 })},
            { typeof(ISprint2Task4V2), (11.5, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V3), (35, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V4), (71.346, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V5), (171.25, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V6), (0.007, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V7), (753.25, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V8), (175.625, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V9), (6560.25, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V10), (93.444, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V11), (92.205, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V12), (9.076, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V13), (48.889, new object[] {9, 4 })}, 
            { typeof(ISprint2Task4V14), (0.272, new object[] {9, 4 })},   
            { typeof(ISprint2Task4V15), (28421.709, new object[] {9, 4 })}, 

            //Task5

            { typeof(ISprint2Task5V1), (30, new object[] {9 })},
            { typeof(ISprint2Task5V2), ("осень", new object[] {9 })},  
            { typeof(ISprint2Task5V3), ("понедельник", new object[] {1 })},  
            { typeof(ISprint2Task5V4), ("трефы", new object[] {2 })},  
            { typeof(ISprint2Task5V5), ("дама", new object[] {12 })},  
            { typeof(ISprint2Task5V6), ("дама пик", new object[] {1, 12 })},  
            { typeof(ISprint2Task5V7), ("март", new object[] {2 })},  
            { typeof(ISprint2Task5V8), ("24 мая", new object[] {5, 25 })},  

            //Task6

            { typeof(ISprint2Task6V1), (30, new object[] {9 })},
            { typeof(ISprint2Task6V2), ("осень", new object[] {9 })},  
            { typeof(ISprint2Task6V3), ("понедельник", new object[] {1 })},  
            { typeof(ISprint2Task6V4), ("трефы", new object[] {2 })},  
            { typeof(ISprint2Task6V5), ("дама", new object[] {12 })},  
            { typeof(ISprint2Task6V6), ("дама пик", new object[] {1, 12 })},  
            { typeof(ISprint2Task6V7), ("март", new object[] {2 })},  
            { typeof(ISprint2Task6V8), ("24 мая", new object[] {5, 25 })},          

            //Task7

            { typeof(ISprint2Task7V1), (true, new object[] {0.5, 0.5 })}, 
            { typeof(ISprint2Task7V2), (true, new object[] {0, 0.5 })}, 
            { typeof(ISprint2Task7V3), (true, new object[] {0.5, -0.5 })}, 
            { typeof(ISprint2Task7V4), (true, new object[] {0.5, 0.3 })}, 
            { typeof(ISprint2Task7V5), (true, new object[] {0, 0.5 })}, 
            { typeof(ISprint2Task7V6), (true, new object[] {1.5, 1 })}, 
            { typeof(ISprint2Task7V7), (true, new object[] {0, 0.5 })}, 
            { typeof(ISprint2Task7V8), (true, new object[] {3, 1 })}, 
        };
        public (object result, object[] args) GetData(Type type)
        {
            return testData[type];
        }

    }
}
