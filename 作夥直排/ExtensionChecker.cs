﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoHoe
{
    static class ExtensionChecker
    {
        public static bool calibreStatus = false;
        public static bool kindleGenStatus = false;
        public static bool pandocStatus = false;

        static ExtensionChecker()
        {
            calibreStatus = CheckCalibre();
            kindleGenStatus = CheckKindlegen();
            pandocStatus = CheckPandoc();
        }
        public static void CheckAll()
        {
            calibreStatus = CheckCalibre();
            kindleGenStatus = CheckKindlegen();
            pandocStatus = CheckPandoc();
        }
        public static bool CheckCalibre()
        {
            string ExeName = "ebook-convert.exe";
            string CalibrePath = ChoHoe.Properties.Settings.Default.CalibrePath;
            if (!File.Exists(CalibrePath + "\\" + ExeName))
            {

                return false;
            }

            return true;

        }
        private static bool CheckKindlegen()
        {
            string ExeName = "kindlegen.exe";
            string KindlegenPath = ChoHoe.Properties.Settings.Default.KindlegenPath;
            if (!File.Exists(KindlegenPath + "\\" + ExeName))
            {

                return false;
            }

            return true;
        }
        private static bool CheckPandoc()
        {
            string ExeName = "pandoc.exe";
            string PandocPath = ChoHoe.Properties.Settings.Default.PandocPath;
            if (!File.Exists(PandocPath + "\\" + ExeName))
            {

                return false;
            }

            return true;
        }
    }
}
