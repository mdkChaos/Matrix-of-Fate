﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matrix_of_Fate.Models
{
    public static class Calculate
    {
        private static DateOfBirth DateOfBirth { get; set; } = new DateOfBirth();
        private static Matrix matrix;

        public static Matrix GetMatrix()
        {
            matrix = new Matrix();
            matrix.Birthday = DateOfBirth.DD.ToString() + "." +
                              DateOfBirth.MM.ToString() + "." +
                              DateOfBirth.Y1.ToString() + DateOfBirth.Y2.ToString() +
                              DateOfBirth.Y3.ToString() + DateOfBirth.Y4.ToString();
            CalculateBigMatrix();
            CalculateSmallMatrix();
            CalculateBigMatrixTable();
            CalculateSmallMatrixTable();
            return matrix;
        }

        public static void SetDateOfBirth(string dateOfBirth)
        {
            string date = dateOfBirth.Replace(".", "").Replace("/", "").Replace("-", "").Replace(" ", "").Trim();
            DateOfBirth.DD = int.TryParse(date[0].ToString() + date[1].ToString(), out int result) ? result : 0;
            DateOfBirth.MM = int.TryParse(date[2].ToString() + date[3].ToString(), out result) ? result : 0;
            DateOfBirth.Y1 = int.TryParse(date[4].ToString(), out result) ? result : 0;
            DateOfBirth.Y2 = int.TryParse(date[5].ToString(), out result) ? result : 0;
            DateOfBirth.Y3 = int.TryParse(date[6].ToString(), out result) ? result : 0;
            DateOfBirth.Y4 = int.TryParse(date[7].ToString(), out result) ? result : 0;
        }

        private static void CalculateBigMatrix()
        {
            matrix.A3 = Add(DateOfBirth.DD);
            matrix.A7 = Add(DateOfBirth.MM);
            matrix.G2 = Add(DateOfBirth.Y1, DateOfBirth.Y2, DateOfBirth.Y3, DateOfBirth.Y4);
            matrix.G6 = Add(matrix.A3, matrix.A7, matrix.G2);
            matrix.G4 = Add(matrix.G2, matrix.G6);
            matrix.A5 = Add(matrix.A3, matrix.A7);
            matrix.A9 = Add(matrix.A7, matrix.G2);
            matrix.A1 = Add(matrix.A3, matrix.G6);
            matrix.A2 = Add(matrix.A1, matrix.A3);
            matrix.A4 = Add(matrix.A3, matrix.A5);
            matrix.A6 = Add(matrix.A5, matrix.A7);
            matrix.A8 = Add(matrix.A7, matrix.A9);
            matrix.E1 = Add(matrix.A3, matrix.A7, matrix.G2, matrix.G6);
            matrix.E2 = Add(matrix.A1, matrix.A5, matrix.A9, matrix.G4);
            matrix.E3 = Add(matrix.E1, matrix.E2);
            matrix.C1 = Add(matrix.A1, matrix.E2);
            matrix.C3 = Add(matrix.A3, matrix.E1);
            matrix.C2 = Add(matrix.C1, matrix.C3);
            matrix.C5 = Add(matrix.A5, matrix.E2);
            matrix.C4 = Add(matrix.C3, matrix.C5);
            matrix.C7 = Add(matrix.A7, matrix.E1);
            matrix.C6 = Add(matrix.C5, matrix.C7);
            matrix.C9 = Add(matrix.A9, matrix.E2);
            matrix.C8 = Add(matrix.C7, matrix.C9);
            matrix.G1 = Add(matrix.A9, matrix.G2);
            matrix.G3 = Add(matrix.G2, matrix.G4);
            matrix.G5 = Add(matrix.G4, matrix.G6);
            matrix.G7 = Add(matrix.A1, matrix.G6);
            matrix.F2 = Add(matrix.E1, matrix.G2);
            matrix.F1 = Add(matrix.C9, matrix.F2);
            matrix.F4 = Add(matrix.E2, matrix.G4);
            matrix.F3 = Add(matrix.F2, matrix.F4);
            matrix.F6 = Add(matrix.E1, matrix.G6);
            matrix.F5 = Add(matrix.F4, matrix.F6);
            matrix.F7 = Add(matrix.C1, matrix.F6);
            matrix.B1 = Add(matrix.A1, matrix.C1);
            matrix.B3 = Add(matrix.A3, matrix.C3);
            matrix.B2 = Add(matrix.B1, matrix.B3);
            matrix.B5 = Add(matrix.A5, matrix.C5);
            matrix.B4 = Add(matrix.B3, matrix.B5);
            matrix.B7 = Add(matrix.A7, matrix.C7);
            matrix.B6 = Add(matrix.B5, matrix.B7);
            matrix.B9 = Add(matrix.A9, matrix.C9);
            matrix.B8 = Add(matrix.B7, matrix.B9);
            matrix.D1 = Add(matrix.E2, matrix.F6);
            matrix.D3 = Add(matrix.C3, matrix.E1);
            matrix.D2 = Add(matrix.D1, matrix.D3);
            matrix.D5 = Add(matrix.C5, matrix.E2);
            matrix.D4 = Add(matrix.D3, matrix.D5);
            matrix.D7 = Add(matrix.C7, matrix.E1);
            matrix.D6 = Add(matrix.D5, matrix.D7);
            matrix.D9 = Add(matrix.C9, matrix.E2);
            matrix.D8 = Add(matrix.D7, matrix.D9);
        }

        private static void CalculateSmallMatrix()
        {
            matrix.SA1 = matrix.SA2 = Add(matrix.A3, matrix.A7);
            matrix.SA3 = Add(matrix.A5, matrix.A5);
            matrix.SA4 = Add(matrix.A4, matrix.A6);
            matrix.SA5 = Add(matrix.A2, matrix.A8);
            matrix.SA9 = Add(matrix.A1, matrix.A9);
            matrix.SA6 = Add(matrix.SA4, matrix.SA5);
            matrix.SA7 = Add(matrix.SA3, matrix.SA9);
            matrix.SA8 = Add(matrix.SA1, matrix.SA2);

            matrix.SB1 = matrix.SB2 = Add(matrix.B3, matrix.B7);
            matrix.SB3 = Add(matrix.B5, matrix.B5);
            matrix.SB4 = Add(matrix.B4, matrix.B6);
            matrix.SB5 = Add(matrix.B2, matrix.B8);
            matrix.SB9 = Add(matrix.B1, matrix.B9);
            matrix.SB6 = Add(matrix.SB4, matrix.SB5);
            matrix.SB7 = Add(matrix.SB3, matrix.SB9);
            matrix.SB8 = Add(matrix.SB1, matrix.SB2);

            matrix.SC1 = matrix.SC2 = Add(matrix.C3, matrix.C7);
            matrix.SC3 = Add(matrix.C5, matrix.C5);
            matrix.SC4 = Add(matrix.C4, matrix.C6);
            matrix.SC5 = Add(matrix.C2, matrix.C8);
            matrix.SC9 = Add(matrix.C1, matrix.C9);
            matrix.SC6 = Add(matrix.SC4, matrix.SC5);
            matrix.SC7 = Add(matrix.SC3, matrix.SC9);
            matrix.SC8 = Add(matrix.SC1, matrix.SC2);

            matrix.SD1 = matrix.SD2 = Add(matrix.D3, matrix.D7);
            matrix.SD3 = Add(matrix.D5, matrix.D5);
            matrix.SD4 = Add(matrix.D4, matrix.D6);
            matrix.SD5 = Add(matrix.D2, matrix.D8);
            matrix.SD9 = Add(matrix.D1, matrix.D9);
            matrix.SD6 = Add(matrix.SD4, matrix.SD5);
            matrix.SD7 = Add(matrix.SD3, matrix.SD9);
            matrix.SD8 = Add(matrix.SD1, matrix.SD2);

            matrix.SE1 = matrix.SE2 = Add(matrix.E1, matrix.E1);
            matrix.SE3 = matrix.SE9 = Add(matrix.E2, matrix.E2);
            matrix.SE4 = matrix.SE5 = Add(matrix.E3, matrix.E3);
            matrix.SE6 = Add(matrix.SE4, matrix.SE5);
            matrix.SE7 = Add(matrix.SE3, matrix.SE9);
            matrix.SE8 = Add(matrix.SE1, matrix.SE2);

            matrix.SF1 = matrix.SF2 = Add(matrix.F2, matrix.F6);
            matrix.SF3 = Add(matrix.F4, matrix.F4);
            matrix.SF4 = Add(matrix.F3, matrix.F5);
            matrix.SF5 = Add(matrix.F1, matrix.F7);
            matrix.SF9 = matrix.SC9;
            matrix.SF6 = Add(matrix.SF4, matrix.SF5);
            matrix.SF7 = Add(matrix.SF3, matrix.SF9);
            matrix.SF8 = Add(matrix.SF1, matrix.SF2);

            matrix.SG1 = matrix.SG2 = Add(matrix.G2, matrix.G6);
            matrix.SG3 = Add(matrix.G4, matrix.G4);
            matrix.SG4 = Add(matrix.G3, matrix.G5);
            matrix.SG5 = Add(matrix.G1, matrix.G7);
            matrix.SG9 = matrix.SA9;
            matrix.SG6 = Add(matrix.SG4, matrix.SG5);
            matrix.SG7 = Add(matrix.SG3, matrix.SG9);
            matrix.SG8 = Add(matrix.SG1, matrix.SG2);
        }

        private static void CalculateBigMatrixTable()
        {
            matrix.R1C1 = matrix.A7 + "-" + matrix.A5 + "-" + matrix.A6;
            matrix.R1C2 = matrix.A3 + "-" + matrix.A5 + "-" + matrix.A4;
            matrix.R1C3 = matrix.SA2 + "-" + matrix.SA3 + "-" + matrix.SA4;
            matrix.R1C4 = matrix.SA8 + "-" + matrix.SA7 + "-" + matrix.SA6;
            matrix.R1C5 = matrix.SA1 + "-" + matrix.SA9 + "-" + matrix.SA5;
            matrix.R1C6 = matrix.A7 + "-" + matrix.A9 + "-" + matrix.A8;
            matrix.R1C7 = matrix.A3 + "-" + matrix.A1 + "-" + matrix.A2;

            matrix.R2C1 = matrix.B7 + "-" + matrix.B5 + "-" + matrix.B6;
            matrix.R2C2 = matrix.B3 + "-" + matrix.B5 + "-" + matrix.B4;
            matrix.R2C3 = matrix.SB2 + "-" + matrix.SB3 + "-" + matrix.SB4;
            matrix.R2C4 = matrix.SB8 + "-" + matrix.SB7 + "-" + matrix.SB6;
            matrix.R2C5 = matrix.SB1 + "-" + matrix.SB9 + "-" + matrix.SB5;
            matrix.R2C6 = matrix.B7 + "-" + matrix.B9 + "-" + matrix.B8;
            matrix.R2C7 = matrix.B3 + "-" + matrix.B1 + "-" + matrix.B2;

            matrix.R3C1 = matrix.C7 + "-" + matrix.C5 + "-" + matrix.C6;
            matrix.R3C2 = matrix.C3 + "-" + matrix.C5 + "-" + matrix.C4;
            matrix.R3C3 = matrix.SC2 + "-" + matrix.SC3 + "-" + matrix.SC4;
            matrix.R3C4 = matrix.SC8 + "-" + matrix.SC7 + "-" + matrix.SC6;
            matrix.R3C5 = matrix.SC1 + "-" + matrix.SC9 + "-" + matrix.SC5;
            matrix.R3C6 = matrix.C7 + "-" + matrix.C9 + "-" + matrix.C8;
            matrix.R3C7 = matrix.C3 + "-" + matrix.C1 + "-" + matrix.C2;

            matrix.R4C1 = matrix.D7 + "-" + matrix.D5 + "-" + matrix.D6;
            matrix.R4C2 = matrix.D3 + "-" + matrix.D5 + "-" + matrix.D4;
            matrix.R4C3 = matrix.SD2 + "-" + matrix.SD3 + "-" + matrix.SD4;
            matrix.R4C4 = matrix.SD8 + "-" + matrix.SD7 + "-" + matrix.SD6;
            matrix.R4C5 = matrix.SD1 + "-" + matrix.SD9 + "-" + matrix.SD5;
            matrix.R4C6 = matrix.D7 + "-" + matrix.D9 + "-" + matrix.D8;
            matrix.R4C7 = matrix.D3 + "-" + matrix.D1 + "-" + matrix.D2;

            matrix.R5C1 = matrix.R5C2 = matrix.R5C6 = matrix.R5C7 = matrix.E1 + "-" + matrix.E2 + "-" + matrix.E3;
            matrix.R5C3 = matrix.SE2 + "-" + matrix.SE3 + "-" + matrix.SE4;
            matrix.R5C4 = matrix.SE8 + "-" + matrix.SE7 + "-" + matrix.SE6;
            matrix.R5C5 = matrix.SE1 + "-" + matrix.SE9 + "-" + matrix.SE5;

            matrix.R6C1 = matrix.F6 + "-" + matrix.F4 + "-" + matrix.F5;
            matrix.R6C2 = matrix.F2 + "-" + matrix.F4 + "-" + matrix.F3;
            matrix.R6C3 = matrix.SF2 + "-" + matrix.SF3 + "-" + matrix.SF4;
            matrix.R6C4 = matrix.SF8 + "-" + matrix.SF7 + "-" + matrix.SF6;
            matrix.R6C5 = matrix.SF1 + "-" + matrix.SF9 + "-" + matrix.SF5;
            matrix.R6C6 = matrix.F6 + "-" + matrix.C1 + "-" + matrix.F7;
            matrix.R6C7 = matrix.F2 + "-" + matrix.C9 + "-" + matrix.F1;

            matrix.R7C1 = matrix.G6 + "-" + matrix.G4 + "-" + matrix.G5;
            matrix.R7C2 = matrix.G2 + "-" + matrix.G4 + "-" + matrix.G3;
            matrix.R7C3 = matrix.SG2 + "-" + matrix.SG3 + "-" + matrix.SG4;
            matrix.R7C4 = matrix.SG8 + "-" + matrix.SG7 + "-" + matrix.SG6;
            matrix.R7C5 = matrix.SG1 + "-" + matrix.SG9 + "-" + matrix.SG5;
            matrix.R7C6 = matrix.G6 + "-" + matrix.A1 + "-" + matrix.G7;
            matrix.R7C7 = matrix.G2 + "-" + matrix.A9 + "-" + matrix.G1;
        }

        private static void CalculateSmallMatrixTable()
        {
            matrix.S1 = Add(matrix.SA3, matrix.SA7);
            matrix.EA1 = Add(matrix.SA1, matrix.SA5);
            matrix.SEA1 = Add(matrix.S1, matrix.EA1);
            matrix.M1 = Add(matrix.SA2, matrix.SA6);
            matrix.W1 = Add(matrix.SA4, matrix.SA8);
            matrix.MW1 = Add(matrix.M1, matrix.W1);
            matrix.K1 = Add(matrix.SEA1, matrix.MW1);

            matrix.S2 = Add(matrix.SB3, matrix.SB7);
            matrix.EA2 = Add(matrix.SB1, matrix.SB5);
            matrix.SEA2 = Add(matrix.S2, matrix.EA2);
            matrix.M2 = Add(matrix.SB2, matrix.SB6);
            matrix.W2 = Add(matrix.SB4, matrix.SB8);
            matrix.MW2 = Add(matrix.M2, matrix.W2);
            matrix.K2 = Add(matrix.SEA2, matrix.MW2);

            matrix.S3 = Add(matrix.SC3, matrix.SC7);
            matrix.EA3 = Add(matrix.SC1, matrix.SC5);
            matrix.SEA3 = Add(matrix.S3, matrix.EA3);
            matrix.M3 = Add(matrix.SC2, matrix.SC6);
            matrix.W3 = Add(matrix.SC4, matrix.SC8);
            matrix.MW3 = Add(matrix.M3, matrix.W3);
            matrix.K3 = Add(matrix.SEA3, matrix.MW3);

            matrix.S4 = Add(matrix.SD3, matrix.SD7);
            matrix.EA4 = Add(matrix.SD1, matrix.SD5);
            matrix.SEA4 = Add(matrix.S4, matrix.EA4);
            matrix.M4 = Add(matrix.SD2, matrix.SD6);
            matrix.W4 = Add(matrix.SD4, matrix.SD8);
            matrix.MW4 = Add(matrix.M4, matrix.W4);
            matrix.K4 = Add(matrix.SEA4, matrix.MW4);

            matrix.S5 = Add(matrix.SE3, matrix.SE7);
            matrix.EA5 = Add(matrix.SE1, matrix.SE5);
            matrix.SEA5 = Add(matrix.S5, matrix.EA5);
            matrix.M5 = Add(matrix.SE2, matrix.SE6);
            matrix.W5 = Add(matrix.SE4, matrix.SE8);
            matrix.MW5 = Add(matrix.M5, matrix.W5);
            matrix.K5 = Add(matrix.SEA5, matrix.MW5);

            matrix.S6 = Add(matrix.SF3, matrix.SF7);
            matrix.EA6 = Add(matrix.SF1, matrix.SF5);
            matrix.SEA6 = Add(matrix.S6, matrix.EA6);
            matrix.M6 = Add(matrix.SF2, matrix.SF6);
            matrix.W6 = Add(matrix.SF4, matrix.SF8);
            matrix.MW6 = Add(matrix.M6, matrix.W6);
            matrix.K6 = Add(matrix.SEA6, matrix.MW6);

            matrix.S7 = Add(matrix.SG3, matrix.SG7);
            matrix.EA7 = Add(matrix.SG1, matrix.SG5);
            matrix.SEA7 = Add(matrix.S7, matrix.EA7);
            matrix.M7 = Add(matrix.SG2, matrix.SG6);
            matrix.W7 = Add(matrix.SG4, matrix.SG8);
            matrix.MW7 = Add(matrix.M7, matrix.W7);
            matrix.K7 = Add(matrix.SEA7, matrix.MW7);
        }

        private static int Add(params int[] args)
        {
            int result = 0;
            for (int i = 0; i < args.Length; i++)
            {
                result += args[i];
            }
            if (result > 22)
            {
                result = result / 10 + result % 10;
            }
            return result;
        }
    }
}
