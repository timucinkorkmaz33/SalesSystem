using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Licence
{
 public static class Licence
    {
       static string Makcode = "";
        public static string ToMD5(this string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            if (metin == null)
            {
                return null;
            }
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            StringBuilder sb = new StringBuilder();

            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }
       
        public static string GetLicenseCode(string makina,string kullanim)
        {
            try
            {
                var anahtar = ToMD5(makina + kullanim).ToUpper();
                var x1 = anahtar.Substring(0, 5);
                var x2 = anahtar.Substring(5, 5);
                var x3 = anahtar.Substring(10, 5);
                var x4 = anahtar.Substring(15, 5);
                var x5 = anahtar.Substring(20, 5);
                anahtar = x1 + "-" + x2 + "-" + x3 + "-" + x4 + "-" + x5; // txt_anahtar adında textboxa oluşan kodu aktarıyoruz.
                return anahtar;
            }


            catch (Exception)
            {
                return "Hatalı İşlem";
            }
        }
        public static string MakinaCode()
        {
            var cpuid = string.Empty;
            var hddserial = string.Empty;
            var motherboardserial = string.Empty;
            var macaddress = string.Empty;

            #region cpu id // Cpu id alma

            string sQuery = "SELECT ProcessorId FROM Win32_Processor";
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher(sQuery);
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
            foreach (ManagementObject oManagementObject in oCollection)
            {
                cpuid = (string)oManagementObject["ProcessorId"];
                break;
            }

            #endregion cpu id

            #region mac address// Mac adresi alma

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    macaddress = adapter.GetPhysicalAddress().ToString();
                }
            }

            #endregion mac address

            #region hdd serial // Harddisk serial alma

            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            hddserial = dsk["VolumeSerialNumber"].ToString();

            #endregion hdd serial

            #region motherboard serial // Motherboard serial alma

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                motherboardserial = (string)mo["SerialNumber"];
                break;
            }

            #endregion motherboard serial

            var anahtar = cpuid.Trim() + "" + hddserial.Trim() + "" + motherboardserial.Trim();
            Makcode = anahtar;
          
            var x1 = anahtar.Substring(0, 5);
            var x2 = anahtar.Substring(5, 5);
            var x3 = anahtar.Substring(10, 5);
            var x4 = anahtar.Substring(15, 5);
            var x5 = anahtar.Substring(20, 5);
            anahtar = x1 + "-" + x2 + "-" + x3 + "-" + x4 + "-" + x5;
            return anahtar;
        }
    }
}
